namespace Tyuiu.PetrovNE.Sprint7.Project0.V10
{
    partial class FormChart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChart));
            this.panelFill_PNE = new System.Windows.Forms.Panel();
            this.panelChart_PNE = new System.Windows.Forms.Panel();
            this.chartOrderCost_PNE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelDown_PNE = new System.Windows.Forms.Panel();
            this.pictureBoxLogo_PNE = new System.Windows.Forms.PictureBox();
            this.buttonExit_PNE = new System.Windows.Forms.Button();
            this.buttonGenerateChartPie_PNE = new System.Windows.Forms.Button();
            this.buttonGenerateChartGistogram_PNE = new System.Windows.Forms.Button();
            this.buttonGenerateChartLine_PNE = new System.Windows.Forms.Button();
            this.toolTip_PNE = new System.Windows.Forms.ToolTip(this.components);
            this.panelFill_PNE.SuspendLayout();
            this.panelChart_PNE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrderCost_PNE)).BeginInit();
            this.panelDown_PNE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo_PNE)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFill_PNE
            // 
            this.panelFill_PNE.BackColor = System.Drawing.Color.White;
            this.panelFill_PNE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFill_PNE.Controls.Add(this.panelChart_PNE);
            this.panelFill_PNE.Controls.Add(this.panelDown_PNE);
            this.panelFill_PNE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_PNE.Location = new System.Drawing.Point(0, 0);
            this.panelFill_PNE.Name = "panelFill_PNE";
            this.panelFill_PNE.Size = new System.Drawing.Size(1400, 710);
            this.panelFill_PNE.TabIndex = 0;
            this.panelFill_PNE.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFill_PNE_Paint);
            // 
            // panelChart_PNE
            // 
            this.panelChart_PNE.Controls.Add(this.chartOrderCost_PNE);
            this.panelChart_PNE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart_PNE.Location = new System.Drawing.Point(0, 0);
            this.panelChart_PNE.Name = "panelChart_PNE";
            this.panelChart_PNE.Size = new System.Drawing.Size(1396, 572);
            this.panelChart_PNE.TabIndex = 2;
            // 
            // chartOrderCost_PNE
            // 
            this.chartOrderCost_PNE.BackColor = System.Drawing.Color.Snow;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            chartArea1.Name = "ChartArea1";
            this.chartOrderCost_PNE.ChartAreas.Add(chartArea1);
            this.chartOrderCost_PNE.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartOrderCost_PNE.Legends.Add(legend1);
            this.chartOrderCost_PNE.Location = new System.Drawing.Point(0, 0);
            this.chartOrderCost_PNE.Name = "chartOrderCost_PNE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.Name = "Стоимость заказа";
            this.chartOrderCost_PNE.Series.Add(series1);
            this.chartOrderCost_PNE.Size = new System.Drawing.Size(1396, 572);
            this.chartOrderCost_PNE.TabIndex = 1;
            this.chartOrderCost_PNE.Text = "Стоимость заказа";
            // 
            // panelDown_PNE
            // 
            this.panelDown_PNE.BackColor = System.Drawing.Color.White;
            this.panelDown_PNE.Controls.Add(this.pictureBoxLogo_PNE);
            this.panelDown_PNE.Controls.Add(this.buttonExit_PNE);
            this.panelDown_PNE.Controls.Add(this.buttonGenerateChartPie_PNE);
            this.panelDown_PNE.Controls.Add(this.buttonGenerateChartGistogram_PNE);
            this.panelDown_PNE.Controls.Add(this.buttonGenerateChartLine_PNE);
            this.panelDown_PNE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown_PNE.Location = new System.Drawing.Point(0, 572);
            this.panelDown_PNE.Name = "panelDown_PNE";
            this.panelDown_PNE.Size = new System.Drawing.Size(1396, 134);
            this.panelDown_PNE.TabIndex = 0;
            // 
            // pictureBoxLogo_PNE
            // 
            this.pictureBoxLogo_PNE.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo_PNE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo_PNE.Image")));
            this.pictureBoxLogo_PNE.Location = new System.Drawing.Point(-2, 0);
            this.pictureBoxLogo_PNE.Name = "pictureBoxLogo_PNE";
            this.pictureBoxLogo_PNE.Size = new System.Drawing.Size(176, 131);
            this.pictureBoxLogo_PNE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo_PNE.TabIndex = 9;
            this.pictureBoxLogo_PNE.TabStop = false;
            this.toolTip_PNE.SetToolTip(this.pictureBoxLogo_PNE, "DATABASEREADER\r\nАвтор: Petrov Nikita\r\nGroup: ASOiUB-23-1");
            // 
            // buttonExit_PNE
            // 
            this.buttonExit_PNE.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit_PNE.FlatAppearance.BorderSize = 0;
            this.buttonExit_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit_PNE.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit_PNE.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit_PNE.Image")));
            this.buttonExit_PNE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit_PNE.Location = new System.Drawing.Point(1200, 36);
            this.buttonExit_PNE.Name = "buttonExit_PNE";
            this.buttonExit_PNE.Size = new System.Drawing.Size(161, 55);
            this.buttonExit_PNE.TabIndex = 8;
            this.buttonExit_PNE.Text = "Назад";
            this.buttonExit_PNE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip_PNE.SetToolTip(this.buttonExit_PNE, "Назад\r\nВыход в главное меню\r\n");
            this.buttonExit_PNE.UseVisualStyleBackColor = false;
            this.buttonExit_PNE.Click += new System.EventHandler(this.buttonExit_PNE_Click);
            // 
            // buttonGenerateChartPie_PNE
            // 
            this.buttonGenerateChartPie_PNE.BackColor = System.Drawing.Color.Transparent;
            this.buttonGenerateChartPie_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerateChartPie_PNE.FlatAppearance.BorderSize = 0;
            this.buttonGenerateChartPie_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateChartPie_PNE.Font = new System.Drawing.Font("Microsoft Yi Baiti", 19F);
            this.buttonGenerateChartPie_PNE.Image = ((System.Drawing.Image)(resources.GetObject("buttonGenerateChartPie_PNE.Image")));
            this.buttonGenerateChartPie_PNE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenerateChartPie_PNE.Location = new System.Drawing.Point(821, 36);
            this.buttonGenerateChartPie_PNE.Name = "buttonGenerateChartPie_PNE";
            this.buttonGenerateChartPie_PNE.Size = new System.Drawing.Size(365, 55);
            this.buttonGenerateChartPie_PNE.TabIndex = 7;
            this.buttonGenerateChartPie_PNE.Text = "Круговая диаграмма";
            this.buttonGenerateChartPie_PNE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip_PNE.SetToolTip(this.buttonGenerateChartPie_PNE, "Круговая диаграмма\r\nПостроить круговую диаграмму\r\n\r\n");
            this.buttonGenerateChartPie_PNE.UseVisualStyleBackColor = false;
            this.buttonGenerateChartPie_PNE.Click += new System.EventHandler(this.buttonGenerateChartPie_PNE_Click);
            // 
            // buttonGenerateChartGistogram_PNE
            // 
            this.buttonGenerateChartGistogram_PNE.BackColor = System.Drawing.Color.Transparent;
            this.buttonGenerateChartGistogram_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerateChartGistogram_PNE.FlatAppearance.BorderSize = 0;
            this.buttonGenerateChartGistogram_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateChartGistogram_PNE.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerateChartGistogram_PNE.Image = ((System.Drawing.Image)(resources.GetObject("buttonGenerateChartGistogram_PNE.Image")));
            this.buttonGenerateChartGistogram_PNE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenerateChartGistogram_PNE.Location = new System.Drawing.Point(526, 40);
            this.buttonGenerateChartGistogram_PNE.Name = "buttonGenerateChartGistogram_PNE";
            this.buttonGenerateChartGistogram_PNE.Size = new System.Drawing.Size(289, 55);
            this.buttonGenerateChartGistogram_PNE.TabIndex = 6;
            this.buttonGenerateChartGistogram_PNE.Text = "Гистограмма";
            this.buttonGenerateChartGistogram_PNE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip_PNE.SetToolTip(this.buttonGenerateChartGistogram_PNE, "Гистограмма\r\nПостроить гистограмму\r\n");
            this.buttonGenerateChartGistogram_PNE.UseVisualStyleBackColor = false;
            this.buttonGenerateChartGistogram_PNE.Click += new System.EventHandler(this.buttonGenerateChartGistogram_PNE_Click);
            // 
            // buttonGenerateChartLine_PNE
            // 
            this.buttonGenerateChartLine_PNE.BackColor = System.Drawing.Color.Transparent;
            this.buttonGenerateChartLine_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerateChartLine_PNE.FlatAppearance.BorderSize = 0;
            this.buttonGenerateChartLine_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateChartLine_PNE.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerateChartLine_PNE.Image = ((System.Drawing.Image)(resources.GetObject("buttonGenerateChartLine_PNE.Image")));
            this.buttonGenerateChartLine_PNE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenerateChartLine_PNE.Location = new System.Drawing.Point(180, 40);
            this.buttonGenerateChartLine_PNE.Name = "buttonGenerateChartLine_PNE";
            this.buttonGenerateChartLine_PNE.Size = new System.Drawing.Size(335, 55);
            this.buttonGenerateChartLine_PNE.TabIndex = 5;
            this.buttonGenerateChartLine_PNE.Text = "Линейный график";
            this.buttonGenerateChartLine_PNE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip_PNE.SetToolTip(this.buttonGenerateChartLine_PNE, "Линейный график\r\nПостроить линейный график \r\n\r\n");
            this.buttonGenerateChartLine_PNE.UseVisualStyleBackColor = false;
            this.buttonGenerateChartLine_PNE.Click += new System.EventHandler(this.buttonGenerateChartLine_PNE_Click);
            // 
            // toolTip_PNE
            // 
            this.toolTip_PNE.IsBalloon = true;
            this.toolTip_PNE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_PNE.ToolTipTitle = "Подсказка";
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 710);
            this.Controls.Add(this.panelFill_PNE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1418, 757);
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построение графиков ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormChart_Load);
            this.panelFill_PNE.ResumeLayout(false);
            this.panelChart_PNE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOrderCost_PNE)).EndInit();
            this.panelDown_PNE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo_PNE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFill_PNE;
        private System.Windows.Forms.Panel panelDown_PNE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrderCost_PNE;
        private System.Windows.Forms.Button buttonGenerateChartLine_PNE;
        private System.Windows.Forms.Button buttonExit_PNE;
        private System.Windows.Forms.Button buttonGenerateChartPie_PNE;
        private System.Windows.Forms.Button buttonGenerateChartGistogram_PNE;
        private System.Windows.Forms.Panel panelChart_PNE;
        private System.Windows.Forms.PictureBox pictureBoxLogo_PNE;
        private System.Windows.Forms.ToolTip toolTip_PNE;
    }
}