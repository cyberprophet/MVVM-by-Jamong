using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMSampleProject.Observable;

namespace MVVMSampleProject.Stock
{
    public class StockRepository
    {
        AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;

        private ObservableDataList<StockModel> stocks;
        private ObservableDataList<PriceHistoryModel> priceHistories;

        private string selectedStock = null;

        public StockRepository(AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI)
        {
            this.axKHOpenAPI = axKHOpenAPI;
            axKHOpenAPI.OnReceiveTrData += API_OnReceiveTrData;
        }

        public ObservableDataList<StockModel> GetStocks()
        {
            if (stocks == null)
            {
                stocks = new ObservableDataList<StockModel>();
                string codeList = axKHOpenAPI.GetCodeListByMarket(null);

                List<StockModel> stockModels = new List<StockModel>();
                foreach(string code in codeList.Trim().Split(';'))
                {
                    if (code.Length == 0)
                        continue;

                    stockModels.Add(new StockModel
                    {
                        Code= code,
                        Name= axKHOpenAPI.GetMasterCodeName(code)
                    });
                }

                stocks.SetValue(stockModels);
            }

            return stocks;
        }

        public ObservableDataList<PriceHistoryModel> GetPriceHistories(string code)
        {
            if(priceHistories == null)
            {
                priceHistories = new ObservableDataList<PriceHistoryModel>();               
            }

            if(selectedStock == null || selectedStock != code)
            {
                selectedStock = code;
                axKHOpenAPI.SetInputValue("종목코드", code);
                axKHOpenAPI.SetInputValue("기준일자", DateTime.Now.ToString("yyyyMMdd"));
                axKHOpenAPI.SetInputValue("수정주가구분", "0");

                axKHOpenAPI.CommRqData("주식일봉차트조회요청", "opt10081", 0, "1000");
            }

            return priceHistories;
        }

        public void API_OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if (!e.sRQName.Equals("주식일봉차트조회요청")) return;
            
            int nCnt = axKHOpenAPI.GetRepeatCnt(e.sTrCode, e.sRQName);
            List<PriceHistoryModel> priceHistoryModels = new List<PriceHistoryModel>();
            for(int i=0; i<nCnt; i++)
            {
                Console.WriteLine("주식일봉차트조회요청" + i);
                priceHistoryModels.Add(new PriceHistoryModel
                {
                    Date = axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "일자").Trim(),
                    Open = Math.Abs(long.Parse(axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "시가").Trim())),
                    Close = Math.Abs(long.Parse(axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Trim())),
                    Low = Math.Abs(long.Parse(axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "저가").Trim())),
                    High = Math.Abs(long.Parse(axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "고가").Trim())),
                    Volume = Math.Abs(long.Parse(axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "거래량").Trim()))
                });
            }
            priceHistories.SetValue(priceHistoryModels);
        }
    }
}
