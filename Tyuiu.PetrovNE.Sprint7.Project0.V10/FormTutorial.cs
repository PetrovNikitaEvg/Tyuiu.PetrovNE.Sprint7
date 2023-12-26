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
    public partial class FormTutorial : Form
    {
        public static FormTutorial instance;
        public FormTutorial()
        {
            InitializeComponent();
            instance = this;
        }
        public bool isshowfirst, isshowsecond, isshowthird;
        public string UserName;

        private void buttonApplyName_PNE_Click(object sender, EventArgs e)
        {
            UserName = textBoxNameUser_PNE.Text;
            this.Hide();
            var form2 = new FormMain();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

      
        private void FormTutorial_Load(object sender, EventArgs e)
        {
            pictureBoxTutorial_PNE.Dock = DockStyle.Fill;
            pictureBoxTutorial_PNE.Width = 1373;
            buttonNextStep_PNE.Width = 514;

            textBoxNameUser_PNE.Visible = false;
            buttonApplyName_PNE.Width = 0;

            panelFill_PNE.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb923"); // change color 

            //Remove Background Selection in NextStep Button
            buttonNextStep_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonNextStep_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //Remove Background Selection in ApplyName Button
            buttonApplyName_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonApplyName_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }

        private void buttonNextStep_PNE_Click(object sender, EventArgs e)
        {
            if (!isshowfirst)
            {
                isshowfirst = true;
                pictureBoxTutorial_PNE.Dock = DockStyle.None;
                pictureBoxTutorial_PNE.Width = 0;

                pictureBoxTutorialStepSecond_PNE.Dock = DockStyle.Fill;
                pictureBoxTutorialStepSecond_PNE.Width = 1373;
            }
            else if (!isshowsecond)
            {
                isshowsecond = true;
                pictureBoxTutorialStepSecond_PNE.Dock = DockStyle.None;
                pictureBoxTutorialStepSecond_PNE.Width = 0;

                pictureBoxTutorialStep3_PNE.Dock = DockStyle.Fill;
                pictureBoxTutorialStep3_PNE.Width = 1373;
            }
            else if (!isshowthird)
            {
                isshowthird = true;
                pictureBoxTutorialStep3_PNE.Dock = DockStyle.None;
                pictureBoxTutorialStep3_PNE.Width = 0;

                pictureBoxTutorialStep4_PNE.Dock = DockStyle.Fill;
                pictureBoxTutorialStep4_PNE.Width = 1373;
                buttonNextStep_PNE.Width = 0;
                
                textBoxNameUser_PNE.Visible = true;
                buttonApplyName_PNE.Width = 375;
            }
        }
    }
}
