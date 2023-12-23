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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public int column;
        private void HideAll()
        {
            panelFileActions_PNE.Width = 0;
            panelDataBaseActions_PNE.Width = 0;

        }
        /*private List<Product> LoadCSV(string csvfile)
        {
            var query = from l in File.ReadAllLines(csvfile)
                        let data = l.Split(',')
                        select new Product
                        {
                            Name = data[0],
                            Surname = data[1],
                            Patronymic = data[2],
                            Account = data[3],
                            Adress = data[4],
                            PhoneNumber = data[5],
                            OrderNumber = data[6],
                            Date = data[7],
                            OrderCost = data[8],
                            ProductName = data[9],
                            ProductCost = data[10],
                            Amount = data[11]
                        };
            return query.ToList();
        }*/ // second metod to load file in datagridview


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
        private void buttonLoadFile_PNE_Click(object sender, EventArgs e)
        {
            advancedDataGridViewDataBase_PNE.Rows.Clear();
            if (!issemicolon)
            {
                try
                {
                    openFileDialog_PNE.ShowDialog();
                    openFilePath = openFileDialog_PNE.FileName;
                    column = System.IO.File.ReadAllLines(openFilePath).Length + 1;


                    advancedDataGridViewDataBase_PNE.ColumnCount = column;
                    using (var reader = new StreamReader(openFilePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');

                            advancedDataGridViewDataBase_PNE.Rows.Add(values);
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
                openFileDialog_PNE.ShowDialog();
                openFilePath = openFileDialog_PNE.FileName;
                column = System.IO.File.ReadAllLines(openFilePath).Length + 1;


                advancedDataGridViewDataBase_PNE.ColumnCount = column;
                using (var reader = new StreamReader(openFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        advancedDataGridViewDataBase_PNE.Rows.Add(values);
                    }
                }
            }
        }

        private void buttonSearch_PNE_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxSearch_PNE_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_PNE.Text.ToLower(); //приведение к нижнему регистру
            foreach (DataGridViewRow row in dataGridViewMain_PSV.Rows)
            {
                if (row.Cells["Номер"].Value != null && row.Cells["Страна"].Value != null)
                {
                    string column1Text = row.Cells["Номер"].Value.ToString().ToLower();
                    string column2Text = row.Cells["Страна"].Value.ToString().ToLower();
                    string column3Text = row.Cells["Столица"].Value.ToString().ToLower();

                    if (column1Text.Contains(searchText) || column2Text.Contains(searchText))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void buttonClear_PNE_Click(object sender, EventArgs e)
        {
            advancedDataGridViewDataBase_PNE.Rows.Clear();
        }

        private void advancedDataGridViewDataBase_PNE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddColumn_PNE_Click(object sender, EventArgs e)
        {

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

                        int rows = advancedDataGridViewDataBase_PNE.RowCount;
                        int columns = advancedDataGridViewDataBase_PNE.ColumnCount;

                        StringBuilder strBuilder = new StringBuilder();

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                strBuilder.Append(advancedDataGridViewDataBase_PNE.Rows[i].Cells[j].Value);

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

                        int rows = advancedDataGridViewDataBase_PNE.RowCount;
                        int columns = advancedDataGridViewDataBase_PNE.ColumnCount;

                        StringBuilder strBuilder = new StringBuilder();

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                strBuilder.Append(advancedDataGridViewDataBase_PNE.Rows[i].Cells[j].Value);

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
  /*  public class Product
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Account { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string OrderNumber { get; set; }
        public string Date { get; set; }
        public string OrderCost { get; set; }
        public string ProductName { get; set; }
        public string ProductCost { get; set; }
        public string Amount { get;set; }
    }
}*/
