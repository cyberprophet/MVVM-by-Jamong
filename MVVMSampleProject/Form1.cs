using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVVMSampleProject.Condition;
using MVVMSampleProject.Stock;


namespace MVVMSampleProject
{
    public partial class Form1 : Form
    {
        ConditionListView conditionListView;
        StockListView stockListView;

        public Form1()
        {
            InitializeComponent();

            this.loginButton.Click += Login_Clicked;

            axKHOpenAPI1.OnEventConnect += API_OnEventConnect;
        }

        public void API_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            Console.WriteLine(e.nErrCode);
            this.loginButton.Visible = false;

            //조건식 리스트 뷰
            conditionListView = new ConditionListView(axKHOpenAPI1);

            this.conditionListPanel.Controls.Add(conditionListView);


            //종목 리스트 뷰
            stockListView = new StockListView(axKHOpenAPI1);
            this.stockListPanel.Controls.Add(stockListView);
        }

        public void Login_Clicked(object sender, EventArgs e)
        {
            axKHOpenAPI1.CommConnect();
        }

    }
}
