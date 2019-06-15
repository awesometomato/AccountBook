namespace WindowsFormsApp1
{
    partial class MonthCompare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.userChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.totalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.userChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalChart)).BeginInit();
            this.SuspendLayout();
            // 
            // userChart
            // 
            this.userChart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            chartArea1.Name = "ChartArea1";
            this.userChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.userChart.Legends.Add(legend1);
            this.userChart.Location = new System.Drawing.Point(12, 13);
            this.userChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userChart.Name = "userChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "수입";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "지출";
            this.userChart.Series.Add(series1);
            this.userChart.Series.Add(series2);
            this.userChart.Size = new System.Drawing.Size(450, 488);
            this.userChart.TabIndex = 0;
            this.userChart.Text = "MonthCompareChart";
            title1.Name = "userTitle";
            title1.Text = "사용자";
            this.userChart.Titles.Add(title1);
            this.userChart.Click += new System.EventHandler(this.userChart_Click);
            // 
            // totalChart
            // 
            chartArea2.Name = "ChartArea1";
            this.totalChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.totalChart.Legends.Add(legend2);
            this.totalChart.Location = new System.Drawing.Point(471, 13);
            this.totalChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.totalChart.Name = "totalChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "수입";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "지출";
            this.totalChart.Series.Add(series3);
            this.totalChart.Series.Add(series4);
            this.totalChart.Size = new System.Drawing.Size(450, 488);
            this.totalChart.TabIndex = 1;
            this.totalChart.Text = "DayCompareChart";
            title2.Name = "전체";
            title2.Text = "전체 사용자";
            this.totalChart.Titles.Add(title2);
            // 
            // MonthCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 514);
            this.Controls.Add(this.totalChart);
            this.Controls.Add(this.userChart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MonthCompare";
            this.Text = "MonthCompare";
            this.Load += new System.EventHandler(this.MonthCompare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart userChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart totalChart;
    }
}