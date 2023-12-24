using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

using Tyuiu.PetrovNE.Sprint7.Project0.V10.Lib;

namespace Tyuiu.PetrovNE.Sprint7.Project0.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public string openFilePath;
        bool isShow = false, isinprogress = false, issemicolon = false;
        public int column, rows;
        public int[] Order_costs_array;
        private void HideAll()
        {
            panelFileActions_PNE.Width = 0;
            panelDataBaseActions_PNE.Width = 0;
            panelStatisticActions_PNE.Width = 0;
        }

        private void RemoveBackgroundSelection()
        {
            //Remove Background Selection in Setting Button
            buttonSetting_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSetting_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //Remove Background Selection in Tutorial Button
            buttonTutorial_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonTutorial_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //Remove Background Selection in About Button
            buttonAbout_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAbout_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //DropListButtons
            //Remove Background Selection in FileDropList button
            buttonFileDropList_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonFileDropList_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //Remove Background Selection in DataBaseDropList button
            buttonDataBaseDropList_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonDataBaseDropList_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //Remove Background Selection in StatisticDropList button
            buttonStatisticDropList_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonStatisticDropList_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //Remove Background Selection in OpenFunctionWindow button
            buttonOpenFunctionWindow_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonOpenFunctionWindow_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //MAIN ACTIONS
            //Remove Background Selection in FileLoad button
            buttonLoadFile_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonLoadFile_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //Remove Background Selection in SaveFile button
            buttonSaveFile_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSaveFile_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;


        }
        private void FormMain_Load(object sender, EventArgs e) // Load funtcion for form
        {
            HideAll(); // hide all buttons with actions
            RemoveBackgroundSelection(); //removing all background selection

            panelSlideLeft_PNE.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFBD59"); // change color in slide panel

            panelSlideLeft_PNE.Width = 0; //make width slide panel equal zero 

            panelSlideLeft_PNE.Hide(); // Panel is hide from load program

        }

        private void pictureBoxSlideMenu_PNE_Click(object sender, EventArgs e)
        {
            if (panelSlideLeft_PNE.Visible) // start timer to close
            {
                isShow = false;
                timerLeftPanel_PNE.Start();
            }
            else // start timer to open
            {
                isShow = true;
                panelSlideLeft_PNE.Show();
                timerLeftPanel_PNE.Start();
            }
        }

        private void timerHidePanel_PNE_Tick(object sender, EventArgs e)
        {
            if (isShow) // flow left panel
            {
                if (panelSlideLeft_PNE.Width == 300)
                    timerLeftPanel_PNE.Stop();

                panelSlideLeft_PNE.Width += 50;
            }
            else // hide left panel
            {
                if (panelSlideLeft_PNE.Width <= 0)
                {
                    panelSlideLeft_PNE.Hide();
                    timerLeftPanel_PNE.Stop();
                    HideAll();
                    isinprogress = false;
                }

                panelSlideLeft_PNE.Width -= 50;
            }
        }

        //MenuActions
        private void buttonSetting_PNE_Click(object sender, EventArgs e) //Setting action
        {
        }


        private void buttonTutorial_PNE_Click(object sender, EventArgs e) //Tutorial action
        {

        }

        private void buttonAbout_PNE_Click(object sender, EventArgs e)//About action
        {

        }

        //DropListActions
        private void buttonDataBaseDropList_PNE_Click(object sender, EventArgs e)
        {
            if (!isShow)
            {
                MessageBox.Show("Необходимо сначала открыть меню", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                if (isinprogress)
                {
                    HideAll();
                    isinprogress = false;
                }

                else
                {
                    isinprogress = true;
                    panelDataBaseActions_PNE.Width = 397;
                }

            }

        }

        private void buttonFileDropList_PNE_Click(object sender, EventArgs e) //File actions
        {
            if (!isShow)
            {
                MessageBox.Show("Необходимо сначала открыть меню", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (isinprogress)
                {
                    HideAll();
                    isinprogress = false;
                }
                else
                {
                    isinprogress = true;
                    panelFileActions_PNE.Width = 397;
                }
            }

        }
        //Statistic
        private void buttonStatisticDropList_PNE_Click(object sender, EventArgs e)
        {
            if (!isShow)
            {
                MessageBox.Show("Необходимо сначала открыть меню", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (isinprogress)
                {
                    HideAll();
                    isinprogress = false;
                }
                else
                {
                    isinprogress = true;
                    panelStatisticActions_PNE.Width = 397;
                }
            }
        }

        private DataGridView GetDataGridViewDataBase_PNE()
        {
            return DataGridViewDataBase_PNE;
        }


        //LOAD FILE
        private void buttonLoadFile_PNE_Click(object sender, EventArgs e)
        {
            DataGridViewDataBase_PNE.AllowUserToAddRows = false;
            DataGridViewDataBase_PNE.Rows.Clear();
            if (!issemicolon)
            {
                try
                {
                    DataGridViewDataBase_PNE.AllowUserToAddRows = false;
                    openFileDialog_PNE.ShowDialog();
                    openFilePath = openFileDialog_PNE.FileName;
                    column = System.IO.File.ReadAllLines(openFilePath, Encoding.UTF8).Length + 1;


                    DataGridViewDataBase_PNE.ColumnCount = column;
                    using (var reader = new StreamReader(openFilePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');

                            DataGridViewDataBase_PNE.Rows.Add(values);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DataGridViewDataBase_PNE.AllowUserToAddRows = false;
                openFileDialog_PNE.ShowDialog();
                openFilePath = openFileDialog_PNE.FileName;
                column = System.IO.File.ReadAllLines(openFilePath, Encoding.UTF8).Length + 1;


                DataGridViewDataBase_PNE.ColumnCount = column;
                using (var reader = new StreamReader(openFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        DataGridViewDataBase_PNE.Rows.Add(values);
                    }
                }
            }
            column = DataGridViewDataBase_PNE.Columns.Count;
            rows = DataGridViewDataBase_PNE.RowCount - 1;
    }


        //SEARCH FUNCTION
        private void textBoxSearch_PNE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchValue = textBoxSearch_PNE.Text.ToLower();

                foreach (DataGridViewRow row in DataGridViewDataBase_PNE.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
                        {
                            cell.Style.BackColor = Color.Yellow; // Цвет подсветки найденной ячейки
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White; // Возврат цвета по умолчанию
                        }
                    }
                }
            }

            catch
            {
                MessageBox.Show("Что-то пошло не так, попробуйте снова", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Clear DataBase
        private void buttonClear_PNE_Click(object sender, EventArgs e)
        {
            DataGridViewDataBase_PNE.Rows.Clear();
        }

        //DATAGRIDVIEW CODE
        private void DataGridViewDataBase_PNE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Remove selection after searching and filter
        private void buttonRemoveSelection_PNE_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < column; i++)
                {
                    for (int j = 0; j < rows + 1; j++)
                    {
                        DataGridViewDataBase_PNE[i, j].Style.BackColor = Color.White;
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Что-то пошло не так, попробуйте снова", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //RELOAD DATABASE
        private void buttonRefresh_PNE_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewDataBase_PNE.AllowUserToAddRows = false;
                DataGridViewDataBase_PNE.Rows.Clear();
                column = System.IO.File.ReadAllLines(openFilePath, Encoding.UTF8).Length + 1;


                DataGridViewDataBase_PNE.ColumnCount = column;
                using (var reader = new StreamReader(openFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        DataGridViewDataBase_PNE.Rows.Add(values);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Невозможно обновить базу данных, проверьте загружали ли вы её", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //FILTER
        private void textBoxFilter_PNE_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonFilter_PNE_Click(object sender, EventArgs e) //Кто украдёт мой код, узнаю ою этом и пожалуюсь в администрацию интернета, поняли!?
        {
            try
            {
                string filterValue = textBoxFilter_PNE.Text.ToLower();
                string[] array = new string[column];
                int count = 0, row_to_select = -1;

                foreach (DataGridViewRow row in DataGridViewDataBase_PNE.Rows)
                {
                    row_to_select++;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(filterValue))
                        {
                            bool InArray = array.Contains(row_to_select.ToString());
                            if (!InArray)
                            {
                                array[count] = row_to_select.ToString();
                                count++;
                            }
                        }
                    }
                }

                int i = 0;
                while (array[i] != null)
                {
                    for (int j = 0; j < column; j++)
                    {
                        DataGridViewDataBase_PNE[j, int.Parse(array[i])].Style.BackColor = Color.Red;
                    }
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так, попробуйте снова", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCompleteActionStatistics_PNE_Click(object sender, EventArgs e)
        {
            Order_costs_array = new int[rows]; //create array for order cost

            int count = 0;

            for (int i = 0; i < rows+1; i++) //add values in array
            {
                bool diddigitwasmeet = false;
                string ResultString = "";
                string CollectedStringValue = (DataGridViewDataBase_PNE.Rows[i].Cells[8].Value.ToString());
                for (int k = 0; k < CollectedStringValue.Length; k++)
                {
                    if (Char.IsDigit(CollectedStringValue[k]))
                    {
                        ResultString += CollectedStringValue[k];
                        diddigitwasmeet = true;
                    }
                }
                if (diddigitwasmeet)
                {
                    Order_costs_array[count] = int.Parse(ResultString);
                    count++;
                }
            }
            DataService ds = new DataService();
            try
            {
                if (comboBoxStatisticActions_PNE.Text == "Минимальная цена заказа")
                {
                    textBoxResult_PNE.Text = ds.GetMinValue(Order_costs_array).ToString();
                }
                else if (comboBoxStatisticActions_PNE.Text == "Максимальная цена заказа")
                {
                    textBoxResult_PNE.Text = ds.GetMaxValue(Order_costs_array).ToString();
                }
                else if (comboBoxStatisticActions_PNE.Text == "Средняя цена заказа")
                {
                    textBoxResult_PNE.Text = ds.GetAverageValue(Order_costs_array).ToString();
                }
                else if (comboBoxStatisticActions_PNE.Text == "Общая сумма всех заказов")
                {
                    textBoxResult_PNE.Text = ds.GetSumValue(Order_costs_array).ToString();
                }
                else if (comboBoxStatisticActions_PNE.Text == "Количество заказов")
                {
                    textBoxResult_PNE.Text = ds.GetCountValue(Order_costs_array).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так, проверьте данные в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddColumn_PNE_Click(object sender, EventArgs e)
        {
                try
            {
                DataGridViewDataBase_PNE.Rows.Add();
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //issemicolon function
        private void checkBoxIssemicolon_PNE_CheckedChanged(object sender, EventArgs e)
        {
            if (issemicolon)
            {
                issemicolon = false;
            }
            else
            {
                issemicolon = true;
            }
        }


        private void buttonSaveFile_PNE_Click(object sender, EventArgs e)
        {
            if (!issemicolon) //save with , split
            {
                try
                {
                    saveFileDialog_PNE.FileName = ".csv";
                    saveFileDialog_PNE.InitialDirectory = @":L";
                    if (saveFileDialog_PNE.ShowDialog() == DialogResult.OK)
                    {
                        string savepath = saveFileDialog_PNE.FileName;

                        if (File.Exists(savepath)) File.Delete(savepath);

                        int rows = DataGridViewDataBase_PNE.RowCount;
                        int columns = DataGridViewDataBase_PNE.ColumnCount;

                        StringBuilder strBuilder = new StringBuilder();

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                strBuilder.Append(DataGridViewDataBase_PNE.Rows[i].Cells[j].Value);

                                if (j != columns - 1) strBuilder.Append(",");
                            }
                            strBuilder.AppendLine();
                        }
                        File.WriteAllText(savepath, strBuilder.ToString(), Encoding.UTF8);
                        MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //save with ; split
            {
                try
                {
                    saveFileDialog_PNE.FileName = ".csv";
                    saveFileDialog_PNE.InitialDirectory = @":L";
                    if (saveFileDialog_PNE.ShowDialog() == DialogResult.OK)
                    {
                        string savepath = saveFileDialog_PNE.FileName;

                        if (File.Exists(savepath)) File.Delete(savepath);

                        int rows = DataGridViewDataBase_PNE.RowCount;
                        int columns = DataGridViewDataBase_PNE.ColumnCount;

                        StringBuilder strBuilder = new StringBuilder();

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                strBuilder.Append(DataGridViewDataBase_PNE.Rows[i].Cells[j].Value);

                                if (j != columns - 1) strBuilder.Append(";");
                            }
                            strBuilder.AppendLine();
                        }
                        File.WriteAllText(savepath, strBuilder.ToString(), Encoding.UTF8);
                        MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
