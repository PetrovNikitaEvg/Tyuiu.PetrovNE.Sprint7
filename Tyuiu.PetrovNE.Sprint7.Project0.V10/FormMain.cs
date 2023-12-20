using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PetrovNE.Sprint7.Project0.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            panelSlideLeft_PNE.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFBD59"); // change color in slide panel
        }
        bool isShow = false , isinprogress = false;
        private void HideAll()
        {
            buttonLoadFile_PNE.Width = 0;
            buttonSaveFile_PNE.Width = 0;
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
                    buttonSaveFile_PNE.Width = 397;
                    buttonLoadFile_PNE.Width = 397;
                }
            }
        }

        //FileDropListActions
        private void buttonLoadFile_PNE_Click(object sender, EventArgs e)
        {
            openFileDialog_PNE.ShowDialog();
        }

        private void buttonSaveFile_PNE_Click(object sender, EventArgs e)
        {
            saveFileDialog_PNE.ShowDialog();
        }
    }
}
