namespace Tyuiu.PetrovNE.Sprint7.Project0.V10
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelAbout_PNE = new System.Windows.Forms.Label();
            this.pictureBoxPhoto_PNE = new System.Windows.Forms.PictureBox();
            this.buttonExit_PNE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_PNE)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAbout_PNE
            // 
            this.labelAbout_PNE.AutoSize = true;
            this.labelAbout_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbout_PNE.Location = new System.Drawing.Point(12, 9);
            this.labelAbout_PNE.Name = "labelAbout_PNE";
            this.labelAbout_PNE.Size = new System.Drawing.Size(829, 126);
            this.labelAbout_PNE.TabIndex = 0;
            this.labelAbout_PNE.Text = "Разработчик: Петров Никита Евгеньевич\r\nВуз: Тюменский индустриальный университет\r" +
    "\nГруппа: АСОиУБ-23-1\r\n";
            // 
            // pictureBoxPhoto_PNE
            // 
            this.pictureBoxPhoto_PNE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto_PNE.Image")));
            this.pictureBoxPhoto_PNE.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto_PNE.InitialImage")));
            this.pictureBoxPhoto_PNE.Location = new System.Drawing.Point(490, 101);
            this.pictureBoxPhoto_PNE.Name = "pictureBoxPhoto_PNE";
            this.pictureBoxPhoto_PNE.Size = new System.Drawing.Size(351, 525);
            this.pictureBoxPhoto_PNE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto_PNE.TabIndex = 1;
            this.pictureBoxPhoto_PNE.TabStop = false;
            // 
            // buttonExit_PNE
            // 
            this.buttonExit_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit_PNE.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit_PNE.FlatAppearance.BorderSize = 0;
            this.buttonExit_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit_PNE.Font = new System.Drawing.Font("Microsoft Yi Baiti", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit_PNE.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit_PNE.Image")));
            this.buttonExit_PNE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit_PNE.Location = new System.Drawing.Point(19, 542);
            this.buttonExit_PNE.Name = "buttonExit_PNE";
            this.buttonExit_PNE.Size = new System.Drawing.Size(313, 84);
            this.buttonExit_PNE.TabIndex = 14;
            this.buttonExit_PNE.Text = "Назад";
            this.buttonExit_PNE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit_PNE.UseVisualStyleBackColor = false;
            this.buttonExit_PNE.Click += new System.EventHandler(this.buttonExit_PNE_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 674);
            this.Controls.Add(this.buttonExit_PNE);
            this.Controls.Add(this.pictureBoxPhoto_PNE);
            this.Controls.Add(this.labelAbout_PNE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1013, 725);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1013, 725);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О разработчике";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_PNE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout_PNE;
        private System.Windows.Forms.PictureBox pictureBoxPhoto_PNE;
        private System.Windows.Forms.Button buttonExit_PNE;
    }
}