
namespace Lab02_Ex02
{
    partial class FormSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_maso = new System.Windows.Forms.RadioButton();
            this.rd_Hoten = new System.Windows.Forms.RadioButton();
            this.rd_SDT = new System.Windows.Forms.RadioButton();
            this.lbl_hint = new System.Windows.Forms.Label();
            this.txt_searchKey = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_SDT);
            this.groupBox1.Controls.Add(this.rd_Hoten);
            this.groupBox1.Controls.Add(this.rd_maso);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo";
            // 
            // rd_maso
            // 
            this.rd_maso.AutoSize = true;
            this.rd_maso.Checked = true;
            this.rd_maso.Location = new System.Drawing.Point(7, 33);
            this.rd_maso.Name = "rd_maso";
            this.rd_maso.Size = new System.Drawing.Size(69, 21);
            this.rd_maso.TabIndex = 0;
            this.rd_maso.TabStop = true;
            this.rd_maso.Text = "Mã Số";
            this.rd_maso.UseVisualStyleBackColor = true;
            this.rd_maso.CheckedChanged += new System.EventHandler(this.rd_maso_CheckedChanged);
            // 
            // rd_Hoten
            // 
            this.rd_Hoten.AutoSize = true;
            this.rd_Hoten.Location = new System.Drawing.Point(141, 33);
            this.rd_Hoten.Name = "rd_Hoten";
            this.rd_Hoten.Size = new System.Drawing.Size(76, 21);
            this.rd_Hoten.TabIndex = 0;
            this.rd_Hoten.Text = "Họ Tên";
            this.rd_Hoten.UseVisualStyleBackColor = true;
            this.rd_Hoten.CheckedChanged += new System.EventHandler(this.rd_Hoten_CheckedChanged);
            // 
            // rd_SDT
            // 
            this.rd_SDT.AutoSize = true;
            this.rd_SDT.Location = new System.Drawing.Point(293, 33);
            this.rd_SDT.Name = "rd_SDT";
            this.rd_SDT.Size = new System.Drawing.Size(69, 21);
            this.rd_SDT.TabIndex = 0;
            this.rd_SDT.Text = "Số ĐT";
            this.rd_SDT.UseVisualStyleBackColor = true;
            this.rd_SDT.CheckedChanged += new System.EventHandler(this.rd_SDT_CheckedChanged);
            // 
            // lbl_hint
            // 
            this.lbl_hint.AutoSize = true;
            this.lbl_hint.Location = new System.Drawing.Point(12, 91);
            this.lbl_hint.Name = "lbl_hint";
            this.lbl_hint.Size = new System.Drawing.Size(46, 17);
            this.lbl_hint.TabIndex = 1;
            this.lbl_hint.Text = "label1";
            // 
            // txt_searchKey
            // 
            this.txt_searchKey.Location = new System.Drawing.Point(141, 88);
            this.txt_searchKey.Name = "txt_searchKey";
            this.txt_searchKey.Size = new System.Drawing.Size(201, 22);
            this.txt_searchKey.TabIndex = 2;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(348, 87);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(50, 25);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 135);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_searchKey);
            this.Controls.Add(this.lbl_hint);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_SDT;
        private System.Windows.Forms.RadioButton rd_Hoten;
        private System.Windows.Forms.RadioButton rd_maso;
        private System.Windows.Forms.Label lbl_hint;
        private System.Windows.Forms.TextBox txt_searchKey;
        private System.Windows.Forms.Button btn_OK;
    }
}