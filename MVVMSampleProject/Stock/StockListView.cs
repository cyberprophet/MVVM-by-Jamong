using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVVMSampleProject.Observable;


namespace MVVMSampleProject.Stock
{
    public partial class StockListView : UserControl
    {
        StockRepository stockRepository;
        StockViewModel stockViewModel;

        public StockListView(AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI)
        {
            InitializeComponent();

            stockRepository = new StockRepository(axKHOpenAPI);
            stockViewModel = new StockViewModel(stockRepository);

            stockViewModel.stocks.Observers += Stock_Observer;
            stockViewModel.priceHistories.Observers += History_Observer;

            SetListToGridView(stockViewModel.stocks.GetValue());

            stockDataGridView.SelectionChanged += this.DataGridView_SelectionChanged;
        }

        private void SetListToGridView(List<StockModel> stocks)
        {
            for (int i = 0; i < stocks.Count; i++)
            {
                int rowIndex = this.stockDataGridView.Rows.Add();
                stockDataGridView["StockCode", rowIndex].Value = stocks[i].Code;
                stockDataGridView["StockName", rowIndex].Value = stocks[i].Name;
            }
        }

        public void Stock_Observer(object sender, ObservableEventArgs<List<StockModel>> e)
        {
            // update UI
            List<StockModel> stocks = e.value;
            SetListToGridView(stocks);
        }

        public void History_Observer(object sender, ObservableEventArgs<List<PriceHistoryModel>> e)
        {
            List<PriceHistoryModel> priceHistories = e.value;

            historyDataGridView.Rows.Clear();
            for (int i = 0; i < priceHistories.Count; i++)
            {
                int rowIndex = this.historyDataGridView.Rows.Add();
                historyDataGridView["HistoryDate", rowIndex].Value = priceHistories[i].Date;
                historyDataGridView["HistoryOpen", rowIndex].Value = priceHistories[i].Open;
                historyDataGridView["HistoryHigh", rowIndex].Value = priceHistories[i].High;
                historyDataGridView["HistoryLow", rowIndex].Value = priceHistories[i].Low;
                historyDataGridView["HistoryClose", rowIndex].Value = priceHistories[i].Close;
                historyDataGridView["HistoryVolume", rowIndex].Value = priceHistories[i].Volume;
            }
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView.Equals(this.stockDataGridView))
            {
                if (dataGridView.SelectedCells.Count > 0)
                {
                    int index = dataGridView.SelectedCells[0].RowIndex;
                    string selectedCode = stockDataGridView["StockCode", index].Value.ToString();

                    Console.WriteLine("selected Code : " + selectedCode);

                    stockViewModel.GetPriceHistories(selectedCode);
                }
            }
        }


    }
}
