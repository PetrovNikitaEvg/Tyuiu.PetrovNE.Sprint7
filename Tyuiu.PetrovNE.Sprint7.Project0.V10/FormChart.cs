using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.PetrovNE.Sprint7.Project0.V10
{
    public partial class FormChart : Form
    {
        public static FormChart instance;
        public FormChart()
        {
            InitializeComponent();
            instance = this;
        }
        public int[] array = FormMain.instance.Order_costs_array;
        public string[] array_Bank_Account = FormMain.instance.Bank_Account_array;
        private void panelFill_PNE_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            //Remove Background Selection in GenerateChartLine Button
            buttonGenerateChartLine_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonGenerateChartLine_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //Remove Background Selection in GenerateChartGistogram Button
            buttonGenerateChartGistogram_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonGenerateChartGistogram_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //Remove Background Selection in GenerateChartPie Button
            buttonGenerateChartPie_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonGenerateChartPie_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //Remove Background Selection in buttonExit Button
            buttonExit_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonExit_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void buttonGenerateChartLine_PNE_Click(object sender, EventArgs e)
        {
            this.chartOrderCost_PNE.ChartAreas[0].AxisX.Title = "Номер счёта"; //X
            this.chartOrderCost_PNE.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Verdana", 8f);
            this.chartOrderCost_PNE.ChartAreas[0].AxisY.Title = "Цена (РУБ)"; // Y
            this.chartOrderCost_PNE.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chartOrderCost_PNE.Legends[0].Enabled = false;
            chartOrderCost_PNE.Series[0].Points.Clear();

            int[] array = FormMain.instance.Order_costs_array;

            for (int i = 0; i < array.Length; i++)
            {
                chartOrderCost_PNE.Series[0].Points.AddXY(array_Bank_Account[i], array[i]);
            }
        }

        private void buttonGenerateChartGistogram_PNE_Click(object sender, EventArgs e)
        {
            this.chartOrderCost_PNE.ChartAreas[0].AxisX.Title = "Номер счёта"; //X
            this.chartOrderCost_PNE.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Verdana", 8f);
            this.chartOrderCost_PNE.ChartAreas[0].AxisY.Title = "Цена (РУБ)"; // Y
            this.chartOrderCost_PNE.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chartOrderCost_PNE.Legends[0].Enabled = false;
            chartOrderCost_PNE.Series[0].Points.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                chartOrderCost_PNE.Series[0].Points.AddXY(array_Bank_Account[i], array[i]);
            }
        }

        private void buttonGenerateChartPie_PNE_Click(object sender, EventArgs e)
        {

            this.chartOrderCost_PNE.ChartAreas[0].AxisX.Title = "Номер счёта"; //X
            this.chartOrderCost_PNE.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Verdana", 8f);
            this.chartOrderCost_PNE.ChartAreas[0].AxisY.Title = "Цена (РУБ)"; // Y
            this.chartOrderCost_PNE.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            this.chartOrderCost_PNE.Legends[0].Enabled = true;
            chartOrderCost_PNE.Series[0].Points.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                chartOrderCost_PNE.Series[0].Points.AddXY(array_Bank_Account[i], array[i]);
            }
        }

        private void buttonExit_PNE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
