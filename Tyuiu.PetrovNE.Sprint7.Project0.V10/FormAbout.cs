using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tyuiu.PetrovNE.Sprint7.Project0.V10
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void HideAll()
        {
            pictureBoxPhoto_PNE.Dock = DockStyle.None;
            pictureBoxPhoto_PNE.Width = 0;
            panelAboutCreator_PNE.Width = 0;
            panelCreationProcess_PNE.Width = 0;
            panelTask_PNE.Width = 0;
        }

        private void buttonExit_PNE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            HideAll();
            panelFill_PNE.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb923"); // change color 

            buttonShowCreatorPhoto_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonShowCreatorPhoto_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            buttonShowAboutCreator_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonShowAboutCreator_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            buttonShowCreatingProcess_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonShowCreatingProcess_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            buttonShowTask_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonShowTask_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            buttonExit_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonExit_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }

        private void buttonShowCreatorPhoto_PNE_Click(object sender, EventArgs e)
        {
            HideAll();
            pictureBoxPhoto_PNE.Dock = DockStyle.Fill;
        }

        private void buttonShowAboutCreator_PNE_Click(object sender, EventArgs e)
        {
            HideAll();
            panelAboutCreator_PNE.Width = 693;
        }


        private void buttonShowCreatingProcess_PNE_Click(object sender, EventArgs e)
        {
            HideAll();
            panelCreationProcess_PNE.Width = 488;

        }

        private void buttonShowTask_PNE_Click(object sender, EventArgs e)
        {
            HideAll();
            panelTask_PNE.Width = 488;
        }

        private void buttonExit_PNE_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //GoTo Buttons
        private void pictureBoxGoToGithub_PNE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/PetrovNikitaEvg");
        }

        private void pictureBoxGoToVk_PNE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/shugizawa");
        }

        private void pictureBoxGoToTg_PNE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/PetrNIkita");
        }
    }
}
