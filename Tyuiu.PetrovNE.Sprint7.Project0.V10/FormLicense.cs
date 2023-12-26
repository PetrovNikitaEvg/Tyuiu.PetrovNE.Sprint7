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
    public partial class FormLicense : Form
    {
        public FormLicense()
        {
            InitializeComponent();
        }

        private void FormLicense_Load(object sender, EventArgs e)
        {

            MessageBox.Show("На проект официально установлена лицензия.\nПопытка украсть код, не указав автора является наказуемой правилами GitHub.\nЛицензия MIT\r\n\r\nCopyright © «2023» «PetrovNikitaEvgenievich»\r\n\r\nДанная лицензия разрешает лицам, получившим копию данного программного обеспечения и сопутствующей документации (в дальнейшем именуемыми «Программное Обеспечение»), безвозмездно использовать Программное Обеспечение без ограничений, включая неограниченное право на использование, копирование, изменение, слияние, публикацию, распространение, сублицензирование и/или продажу копий Программного Обеспечения, а также лицам, которым предоставляется данное Программное Обеспечение, при соблюдении следующих условий:\r\n\r\nУказанное выше уведомление об авторском праве и данные условия должны быть включены во все копии или значимые части данного Программного Обеспечения.\r\n\r\nДАННОЕ ПРОГРАММНОЕ ОБЕСПЕЧЕНИЕ ПРЕДОСТАВЛЯЕТСЯ «КАК ЕСТЬ», БЕЗ КАКИХ-ЛИБО ГАРАНТИЙ, ЯВНО ВЫРАЖЕННЫХ ИЛИ ПОДРАЗУМЕВАЕМЫХ, ВКЛЮЧАЯ ГАРАНТИИ ТОВАРНОЙ ПРИГОДНОСТИ, СООТВЕТСТВИЯ ПО ЕГО КОНКРЕТНОМУ НАЗНАЧЕНИЮ И ОТСУТСТВИЯ НАРУШЕНИЙ, НО НЕ ОГРАНИЧИВАЯСЬ ИМИ. НИ В КАКОМ СЛУЧАЕ АВТОРЫ ИЛИ ПРАВООБЛАДАТЕЛИ НЕ НЕСУТ ОТВЕТСТВЕННОСТИ ПО КАКИМ-ЛИБО ИСКАМ, ЗА УЩЕРБ ИЛИ ПО ИНЫМ ТРЕБОВАНИЯМ, В ТОМ ЧИСЛЕ, ПРИ ДЕЙСТВИИ КОНТРАКТА, ДЕЛИКТЕ ИЛИ ИНОЙ СИТУАЦИИ, ВОЗНИКШИМ ИЗ-ЗА ИСПОЛЬЗОВАНИЯ ПРОГРАММНОГО ОБЕСПЕЧЕНИЯ ИЛИ ИНЫХ ДЕЙСТВИЙ С ПРОГРАММНЫМ ОБЕСПЕЧЕНИЕМ.", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            panelFill_PNE.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb923"); // change color 

            panelDown_PNE.Dock = DockStyle.None;
            panelDown_PNE.Width = 0;

            buttonRead_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRead_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            buttonDiscline_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonDiscline_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            buttonApply_PNE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonApply_PNE.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }

        private void buttonRead_PNE_Click(object sender, EventArgs e)
        {
            panelDown_PNE.Dock = DockStyle.Bottom;
            buttonRead_PNE.Width = 0;
        }

        private void buttonDiscline_PNE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApply_PNE_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FormTutorial();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
