using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tyuiu.PetrovNE.Sprint7.Project0.V10
{
    public partial class FormSetting : Form
    {
        public static FormSetting instance;
        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            buttonApply_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonApply_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            buttonExit_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonExit_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }

        private void buttonApply_PNE_Click(object sender, EventArgs e)
        {
            if (!(comboBoxMusicStatus_PNE.Text == "Включить музыку"))
            {
                FormMain.sp0.Stop();
                FormMain.sp1.Stop();
            }
            else
            {
                if (comboBoxMusicChoose_PNE.Text == "Bad Piggies")
                {
                    FormMain.sp0.PlayLooping();
                }
                else
                {
                    FormMain.sp1.PlayLooping();
                }
            }
        }

        private void buttonExit_PNE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
