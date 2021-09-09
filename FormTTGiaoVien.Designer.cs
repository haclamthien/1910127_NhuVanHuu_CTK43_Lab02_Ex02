
namespace Lab02_Ex02
{
    partial class FormTTGiaoVien
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
            this.lbl_TTGiaoVien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_TTGiaoVien
            // 
            this.lbl_TTGiaoVien.AutoSize = true;
            this.lbl_TTGiaoVien.Location = new System.Drawing.Point(13, 13);
            this.lbl_TTGiaoVien.Name = "lbl_TTGiaoVien";
            this.lbl_TTGiaoVien.Size = new System.Drawing.Size(46, 17);
            this.lbl_TTGiaoVien.TabIndex = 0;
            this.lbl_TTGiaoVien.Text = "label1";
            // 
            // FormTTGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_TTGiaoVien);
            this.Name = "FormTTGiaoVien";
            this.Text = "FormTTGiaoVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TTGiaoVien;
    }
}