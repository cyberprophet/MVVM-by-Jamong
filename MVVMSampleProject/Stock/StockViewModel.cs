using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMSampleProject.Observable;

namespace MVVMSampleProject.Stock
{
    class StockViewModel
    {
        private StockRepository stockRepository;
        public ObservableDataList<StockModel> stocks { get; set; }
        public ObservableDataList<PriceHistoryModel> priceHistories { get; set; }

        public StockViewModel(StockRepository stockRepository)
        {
            this.stockRepository = stockRepository;
            this.stocks = stockRepository.GetStocks();
            this.priceHistories = stockRepository.GetPriceHistories(stocks.GetValue()[0].Code);
        }

        public ObservableDataList<PriceHistoryModel> GetPriceHistories(string code)
        {
            return stockRepository.GetPriceHistories(code);
        }
    }
}
