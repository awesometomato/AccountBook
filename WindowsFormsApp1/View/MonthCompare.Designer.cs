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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.userChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.totalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.userLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalChart)).BeginInit();
            this.SuspendLayout();
            // 
            // userChart
            // 
            this.userChart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            chartArea3.Name = "ChartArea1";
            this.userChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.userChart.Legends.Add(legend3);
            this.userChart.Location = new System.Drawing.Point(12, 49);
            this.userChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userChart.Name = "userChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "수입";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "지출";
            this.userChart.Series.Add(series5);
            this.userChart.Series.Add(series6);
            this.userChart.Size = new System.Drawing.Size(450, 452);
            this.userChart.TabIndex = 0;
            this.userChart.Text = "MonthCompareChart";
            this.userChart.Click += new System.EventHandler(this.userChart_Click);
            // 
            // totalChart
            // 
            chartArea4.Name = "ChartArea1";
            this.totalChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.totalChart.Legends.Add(legend4);
            this.totalChart.Location = new System.Drawing.Point(471, 49);
            this.totalChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.totalChart.Name = "totalChart";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "수입";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "지출";
            this.totalChart.Series.Add(series7);
            this.totalChart.Series.Add(series8);
            this.totalChart.Size = new System.Drawing.Size(450, 452);
            this.totalChart.TabIndex = 1;
            this.totalChart.Text = "DayCompareChart";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("굴림", 15F);
            this.userLabel.Location = new System.Drawing.Point(169, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(77, 25);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "label1";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("굴림", 15F);
            this.totalLabel.Location = new System.Drawing.Point(669, 9);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(62, 25);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "전체";
            // 
            // MonthCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 514);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.totalChart);
            this.Controls.Add(this.userChart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MonthCompare";
            this.Text = "MonthCompare";
            this.Load += new System.EventHandler(this.MonthCompare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart userChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart totalChart;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label totalLabel;
    }
}