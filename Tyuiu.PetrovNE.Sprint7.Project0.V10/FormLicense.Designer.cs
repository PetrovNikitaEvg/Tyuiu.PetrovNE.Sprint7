namespace Tyuiu.PetrovNE.Sprint7.Project0.V10
{
    partial class FormLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLicense));
            this.panelFill_PNE = new System.Windows.Forms.Panel();
            this.labelLicense_PNE = new System.Windows.Forms.Label();
            this.panelDown_PNE = new System.Windows.Forms.Panel();
            this.buttonDiscline_PNE = new System.Windows.Forms.Button();
            this.buttonApply_PNE = new System.Windows.Forms.Button();
            this.buttonRead_PNE = new System.Windows.Forms.Button();
            this.panelFill_PNE.SuspendLayout();
            this.panelDown_PNE.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFill_PNE
            // 
            this.panelFill_PNE.Controls.Add(this.buttonRead_PNE);
            this.panelFill_PNE.Controls.Add(this.panelDown_PNE);
            this.panelFill_PNE.Controls.Add(this.labelLicense_PNE);
            this.panelFill_PNE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_PNE.Location = new System.Drawing.Point(0, 0);
            this.panelFill_PNE.Name = "panelFill_PNE";
            this.panelFill_PNE.Size = new System.Drawing.Size(902, 610);
            this.panelFill_PNE.TabIndex = 0;
            // 
            // labelLicense_PNE
            // 
            this.labelLicense_PNE.AutoSize = true;
            this.labelLicense_PNE.BackColor = System.Drawing.Color.Transparent;
            this.labelLicense_PNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLicense_PNE.Location = new System.Drawing.Point(4, 4);
            this.labelLicense_PNE.Name = "labelLicense_PNE";
            this.labelLicense_PNE.Size = new System.Drawing.Size(777, 420);
            this.labelLicense_PNE.TabIndex = 0;
            this.labelLicense_PNE.Text = resources.GetString("labelLicense_PNE.Text");
            // 
            // panelDown_PNE
            // 
            this.panelDown_PNE.Controls.Add(this.buttonApply_PNE);
            this.panelDown_PNE.Controls.Add(this.buttonDiscline_PNE);
            this.panelDown_PNE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown_PNE.Location = new System.Drawing.Point(0, 525);
            this.panelDown_PNE.Name = "panelDown_PNE";
            this.panelDown_PNE.Size = new System.Drawing.Size(902, 85);
            this.panelDown_PNE.TabIndex = 1;
            // 
            // buttonDiscline_PNE
            // 
            this.buttonDiscline_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDiscline_PNE.BackColor = System.Drawing.Color.Transparent;
            this.buttonDiscline_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDiscline_PNE.FlatAppearance.BorderSize = 0;
            this.buttonDiscline_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiscline_PNE.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiscline_PNE.Image = ((System.Drawing.Image)(resources.GetObject("buttonDiscline_PNE.Image")));
            this.buttonDiscline_PNE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDiscline_PNE.Location = new System.Drawing.Point(8, 20);
            this.buttonDiscline_PNE.Name = "buttonDiscline_PNE";
            this.buttonDiscline_PNE.Size = new System.Drawing.Size(218, 53);
            this.buttonDiscline_PNE.TabIndex = 2;
            this.buttonDiscline_PNE.Text = "Выйти";
            this.buttonDiscline_PNE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDiscline_PNE.UseVisualStyleBackColor = false;
            this.buttonDiscline_PNE.Click += new System.EventHandler(this.buttonDiscline_PNE_Click);
            // 
            // buttonApply_PNE
            // 
            this.buttonApply_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply_PNE.BackColor = System.Drawing.Color.Transparent;
            this.buttonApply_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApply_PNE.FlatAppearance.BorderSize = 0;
            this.buttonApply_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply_PNE.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApply_PNE.Image = ((System.Drawing.Image)(resources.GetObject("buttonApply_PNE.Image")));
            this.buttonApply_PNE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApply_PNE.Location = new System.Drawing.Point(666, 20);
            this.buttonApply_PNE.Name = "buttonApply_PNE";
            this.buttonApply_PNE.Size = new System.Drawing.Size(233, 53);
            this.buttonApply_PNE.TabIndex = 3;
            this.buttonApply_PNE.Text = "Принять";
            this.buttonApply_PNE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonApply_PNE.UseVisualStyleBackColor = false;
            this.buttonApply_PNE.Click += new System.EventHandler(this.buttonApply_PNE_Click);
            // 
            // buttonRead_PNE
            // 
            this.buttonRead_PNE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRead_PNE.BackColor = System.Drawing.Color.Transparent;
            this.buttonRead_PNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRead_PNE.FlatAppearance.BorderSize = 0;
            this.buttonRead_PNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRead_PNE.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRead_PNE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRead_PNE.Location = new System.Drawing.Point(229, 427);
            this.buttonRead_PNE.Name = "buttonRead_PNE";
            this.buttonRead_PNE.Size = new System.Drawing.Size(436, 53);
            this.buttonRead_PNE.TabIndex = 4;
            this.buttonRead_PNE.Text = "Ознакомлен(а)";
            this.buttonRead_PNE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRead_PNE.UseVisualStyleBackColor = false;
            this.buttonRead_PNE.Click += new System.EventHandler(this.buttonRead_PNE_Click);
            // 
            // FormLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(902, 610);
            this.Controls.Add(this.panelFill_PNE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(924, 661);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(924, 661);
            this.Name = "FormLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLicense";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormLicense_Load);
            this.panelFill_PNE.ResumeLayout(false);
            this.panelFill_PNE.PerformLayout();
            this.panelDown_PNE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFill_PNE;
        private System.Windows.Forms.Label labelLicense_PNE;
        private System.Windows.Forms.Panel panelDown_PNE;
        private System.Windows.Forms.Button buttonDiscline_PNE;
        private System.Windows.Forms.Button buttonApply_PNE;
        private System.Windows.Forms.Button buttonRead_PNE;
    }
}