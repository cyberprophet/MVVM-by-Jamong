namespace MVVMSampleProject.Stock
{
    partial class StockListView
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.StockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.HistoryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryHigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryLow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryClose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AllowUserToAddRows = false;
            this.stockDataGridView.AllowUserToDeleteRows = false;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockCode,
            this.StockName});
            this.stockDataGridView.Location = new System.Drawing.Point(3, 3);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.RowHeadersVisible = false;
            this.stockDataGridView.RowTemplate.Height = 23;
            this.stockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDataGridView.Size = new System.Drawing.Size(201, 420);
            this.stockDataGridView.TabIndex = 0;
            // 
            // StockCode
            // 
            this.StockCode.HeaderText = "종목코드";
            this.StockCode.Name = "StockCode";
            this.StockCode.ReadOnly = true;
            // 
            // StockName
            // 
            this.StockName.HeaderText = "종목명";
            this.StockName.Name = "StockName";
            this.StockName.ReadOnly = true;
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.AllowUserToAddRows = false;
            this.historyDataGridView.AllowUserToDeleteRows = false;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HistoryDate,
            this.HistoryOpen,
            this.HistoryHigh,
            this.HistoryLow,
            this.HistoryClose,
            this.HistoryVolume});
            this.historyDataGridView.Location = new System.Drawing.Point(210, 3);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.RowHeadersVisible = false;
            this.historyDataGridView.RowTemplate.Height = 23;
            this.historyDataGridView.Size = new System.Drawing.Size(587, 420);
            this.historyDataGridView.TabIndex = 1;
            // 
            // HistoryDate
            // 
            this.HistoryDate.HeaderText = "일자";
            this.HistoryDate.Name = "HistoryDate";
            this.HistoryDate.ReadOnly = true;
            // 
            // HistoryOpen
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.HistoryOpen.DefaultCellStyle = dataGridViewCellStyle1;
            this.HistoryOpen.HeaderText = "시가";
            this.HistoryOpen.Name = "HistoryOpen";
            this.HistoryOpen.ReadOnly = true;
            // 
            // HistoryHigh
            // 
            dataGridViewCellStyle2.Format = "N0";
            this.HistoryHigh.DefaultCellStyle = dataGridViewCellStyle2;
            this.HistoryHigh.HeaderText = "고가";
            this.HistoryHigh.Name = "HistoryHigh";
            this.HistoryHigh.ReadOnly = true;
            // 
            // HistoryLow
            // 
            dataGridViewCellStyle3.Format = "N0";
            this.HistoryLow.DefaultCellStyle = dataGridViewCellStyle3;
            this.HistoryLow.HeaderText = "저가";
            this.HistoryLow.Name = "HistoryLow";
            this.HistoryLow.ReadOnly = true;
            // 
            // HistoryClose
            // 
            dataGridViewCellStyle4.Format = "N0";
            this.HistoryClose.DefaultCellStyle = dataGridViewCellStyle4;
            this.HistoryClose.HeaderText = "종가";
            this.HistoryClose.Name = "HistoryClose";
            this.HistoryClose.ReadOnly = true;
            // 
            // HistoryVolume
            // 
            dataGridViewCellStyle5.Format = "N0";
            this.HistoryVolume.DefaultCellStyle = dataGridViewCellStyle5;
            this.HistoryVolume.HeaderText = "거래량";
            this.HistoryVolume.Name = "HistoryVolume";
            this.HistoryVolume.ReadOnly = true;
            // 
            // StockListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.historyDataGridView);
            this.Controls.Add(this.stockDataGridView);
            this.Name = "StockListView";
            this.Size = new System.Drawing.Size(800, 429);
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockName;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryHigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryVolume;
    }
}
