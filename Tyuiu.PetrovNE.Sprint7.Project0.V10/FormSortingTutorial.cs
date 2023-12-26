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
    public partial class FormSortingTutorial : Form
    {
        public FormSortingTutorial()
        {
            InitializeComponent();
        }

        private void FormSortingTutorial_Load(object sender, EventArgs e)
        {
            panelFill_PNE.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb923"); // change color 
            //Remove Background Selection in Exit Button
            buttonExit_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonExit_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void buttonExit_PNE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
