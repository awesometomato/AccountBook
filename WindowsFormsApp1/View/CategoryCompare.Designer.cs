namespace WindowsFormsApp1
{
    partial class CategoryCompare
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint41 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint42 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint43 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint44 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint45 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint46 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint47 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint48 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint49 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint50 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint51 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint52 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint53 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint54 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint55 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint56 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint57 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint58 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint59 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint60 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.userBtn = new System.Windows.Forms.Button();
            this.totalBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 73);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "지출";
            dataPoint41.AxisLabel = "식비";
            dataPoint41.IsValueShownAsLabel = true;
            dataPoint42.AxisLabel = "교통비";
            dataPoint42.IsValueShownAsLabel = true;
            dataPoint43.AxisLabel = "문화생활";
            dataPoint43.IsValueShownAsLabel = true;
            dataPoint44.AxisLabel = "생필품";
            dataPoint44.IsValueShownAsLabel = true;
            dataPoint45.AxisLabel = "의류";
            dataPoint45.IsValueShownAsLabel = true;
            dataPoint46.AxisLabel = "미용";
            dataPoint46.IsValueShownAsLabel = true;
            dataPoint47.AxisLabel = "의료/건강";
            dataPoint47.IsValueShownAsLabel = true;
            dataPoint48.AxisLabel = "교육";
            dataPoint48.IsValueShownAsLabel = true;
            dataPoint49.AxisLabel = "통신비";
            dataPoint49.IsValueShownAsLabel = true;
            dataPoint50.AxisLabel = "회비";
            dataPoint50.IsValueShownAsLabel = true;
            dataPoint51.AxisLabel = "경조사";
            dataPoint51.IsValueShownAsLabel = true;
            dataPoint52.AxisLabel = "저축";
            dataPoint52.IsValueShownAsLabel = true;
            dataPoint53.AxisLabel = "가전";
            dataPoint53.IsValueShownAsLabel = true;
            dataPoint54.AxisLabel = "공과금";
            dataPoint54.IsValueShownAsLabel = true;
            dataPoint55.AxisLabel = "카드대금";
            dataPoint55.IsValueShownAsLabel = true;
            series5.Points.Add(dataPoint41);
            series5.Points.Add(dataPoint42);
            series5.Points.Add(dataPoint43);
            series5.Points.Add(dataPoint44);
            series5.Points.Add(dataPoint45);
            series5.Points.Add(dataPoint46);
            series5.Points.Add(dataPoint47);
            series5.Points.Add(dataPoint48);
            series5.Points.Add(dataPoint49);
            series5.Points.Add(dataPoint50);
            series5.Points.Add(dataPoint51);
            series5.Points.Add(dataPoint52);
            series5.Points.Add(dataPoint53);
            series5.Points.Add(dataPoint54);
            series5.Points.Add(dataPoint55);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(452, 428);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "CategoryCompareChart";
            title5.Name = "지출";
            title5.Text = "지출";
            this.chart1.Titles.Add(title5);
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(470, 73);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "수입";
            dataPoint56.AxisLabel = "월급";
            dataPoint56.IsValueShownAsLabel = true;
            dataPoint57.AxisLabel = "용돈";
            dataPoint57.IsValueShownAsLabel = true;
            dataPoint58.AxisLabel = "이월";
            dataPoint58.IsValueShownAsLabel = true;
            dataPoint59.AxisLabel = "자산인출";
            dataPoint59.IsValueShownAsLabel = true;
            dataPoint60.AxisLabel = "기타";
            dataPoint60.IsValueShownAsLabel = true;
            dataPoint60.IsVisibleInLegend = true;
            series6.Points.Add(dataPoint56);
            series6.Points.Add(dataPoint57);
            series6.Points.Add(dataPoint58);
            series6.Points.Add(dataPoint59);
            series6.Points.Add(dataPoint60);
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(452, 428);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "CategoryCompareChart";
            title6.Name = "수입";
            title6.Text = "수입";
            this.chart2.Titles.Add(title6);
            // 
            // userBtn
            // 
            this.userBtn.Location = new System.Drawing.Point(342, 15);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(121, 33);
            this.userBtn.TabIndex = 2;
            this.userBtn.Text = "사용자id";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // totalBtn
            // 
            this.totalBtn.Location = new System.Drawing.Point(469, 15);
            this.totalBtn.Name = "totalBtn";
            this.totalBtn.Size = new System.Drawing.Size(121, 33);
            this.totalBtn.TabIndex = 3;
            this.totalBtn.Text = "모든 사용자";
            this.totalBtn.UseVisualStyleBackColor = true;
            this.totalBtn.Click += new System.EventHandler(this.totalBtn_Click);
            // 
            // CategoryCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 514);
            this.Controls.Add(this.totalBtn);
            this.Controls.Add(this.userBtn);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CategoryCompare";
            this.Text = "CategoryCompare";
            this.Load += new System.EventHandler(this.CategoryCompare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button totalBtn;
    }
}