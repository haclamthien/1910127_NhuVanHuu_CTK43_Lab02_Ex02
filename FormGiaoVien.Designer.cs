
namespace Lab02_Ex02
{
    partial class FormGiaoVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_MaSo = new System.Windows.Forms.ComboBox();
            this.rd_Nam = new System.Windows.Forms.RadioButton();
            this.rd_Nu = new System.Windows.Forms.RadioButton();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.dtpk_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.msktxt_SoDT = new System.Windows.Forms.MaskedTextBox();
            this.cklsb_NgoaiNgu = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lsb_DsMonHoc = new System.Windows.Forms.ListBox();
            this.lstb_MonHocDay = new System.Windows.Forms.ListBox();
            this.btn_RightAdd = new System.Windows.Forms.Button();
            this.btn_leftAdd = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lkbl_LienHe = new System.Windows.Forms.LinkLabel();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN GIÁO VIÊN KHOA CÔNG NGHỆ THÔNG TIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số ĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày Sinh";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Địa chỉ Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ngoại Ngữ";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbb_MaSo
            // 
            this.cbb_MaSo.FormattingEnabled = true;
            this.cbb_MaSo.Location = new System.Drawing.Point(135, 66);
            this.cbb_MaSo.Name = "cbb_MaSo";
            this.cbb_MaSo.Size = new System.Drawing.Size(222, 24);
            this.cbb_MaSo.TabIndex = 1;
            this.cbb_MaSo.SelectedIndexChanged += new System.EventHandler(this.cbb_MaSo_SelectedIndexChanged);
            // 
            // rd_Nam
            // 
            this.rd_Nam.AutoSize = true;
            this.rd_Nam.Location = new System.Drawing.Point(494, 70);
            this.rd_Nam.Name = "rd_Nam";
            this.rd_Nam.Size = new System.Drawing.Size(58, 21);
            this.rd_Nam.TabIndex = 3;
            this.rd_Nam.TabStop = true;
            this.rd_Nam.Text = "Nam";
            this.rd_Nam.UseVisualStyleBackColor = true;
            // 
            // rd_Nu
            // 
            this.rd_Nu.AutoSize = true;
            this.rd_Nu.Location = new System.Drawing.Point(591, 69);
            this.rd_Nu.Name = "rd_Nu";
            this.rd_Nu.Size = new System.Drawing.Size(47, 21);
            this.rd_Nu.TabIndex = 4;
            this.rd_Nu.TabStop = true;
            this.rd_Nu.Text = "Nữ";
            this.rd_Nu.UseVisualStyleBackColor = true;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(135, 112);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(222, 22);
            this.txt_HoTen.TabIndex = 5;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(494, 152);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(274, 22);
            this.txt_Email.TabIndex = 8;
            // 
            // dtpk_NgaySinh
            // 
            this.dtpk_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpk_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_NgaySinh.Location = new System.Drawing.Point(135, 152);
            this.dtpk_NgaySinh.Name = "dtpk_NgaySinh";
            this.dtpk_NgaySinh.Size = new System.Drawing.Size(222, 22);
            this.dtpk_NgaySinh.TabIndex = 7;
            // 
            // msktxt_SoDT
            // 
            this.msktxt_SoDT.Location = new System.Drawing.Point(494, 117);
            this.msktxt_SoDT.Mask = "(\\0633).000.000";
            this.msktxt_SoDT.Name = "msktxt_SoDT";
            this.msktxt_SoDT.Size = new System.Drawing.Size(274, 22);
            this.msktxt_SoDT.TabIndex = 6;
            // 
            // cklsb_NgoaiNgu
            // 
            this.cklsb_NgoaiNgu.FormattingEnabled = true;
            this.cklsb_NgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Nga"});
            this.cklsb_NgoaiNgu.Location = new System.Drawing.Point(135, 195);
            this.cklsb_NgoaiNgu.Name = "cklsb_NgoaiNgu";
            this.cklsb_NgoaiNgu.Size = new System.Drawing.Size(222, 123);
            this.cklsb_NgoaiNgu.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Danh Sách Môn Học";
            this.label9.Click += new System.EventHandler(this.label6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(491, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Môn Học Giáo Viên Dạy";
            this.label10.Click += new System.EventHandler(this.label6_Click);
            // 
            // lsb_DsMonHoc
            // 
            this.lsb_DsMonHoc.FormattingEnabled = true;
            this.lsb_DsMonHoc.ItemHeight = 16;
            this.lsb_DsMonHoc.Items.AddRange(new object[] {
            "Tin học cơ sở",
            "Lập trình cấu trúc C/C++",
            "Cơ sở dữ liệu",
            "Tiếng Anh B1",
            "Tiếng Anh B2",
            "Lập trình hướng đối tượng",
            "Mạng máy tính",
            "Công nghệ phần mềm",
            "Phân tích thiết kế HDT"});
            this.lsb_DsMonHoc.Location = new System.Drawing.Point(135, 342);
            this.lsb_DsMonHoc.Name = "lsb_DsMonHoc";
            this.lsb_DsMonHoc.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsb_DsMonHoc.Size = new System.Drawing.Size(222, 148);
            this.lsb_DsMonHoc.TabIndex = 10;
            // 
            // lstb_MonHocDay
            // 
            this.lstb_MonHocDay.FormattingEnabled = true;
            this.lstb_MonHocDay.ItemHeight = 16;
            this.lstb_MonHocDay.Location = new System.Drawing.Point(494, 342);
            this.lstb_MonHocDay.Name = "lstb_MonHocDay";
            this.lstb_MonHocDay.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstb_MonHocDay.Size = new System.Drawing.Size(222, 148);
            this.lstb_MonHocDay.TabIndex = 11;
            // 
            // btn_RightAdd
            // 
            this.btn_RightAdd.Location = new System.Drawing.Point(398, 371);
            this.btn_RightAdd.Name = "btn_RightAdd";
            this.btn_RightAdd.Size = new System.Drawing.Size(50, 30);
            this.btn_RightAdd.TabIndex = 12;
            this.btn_RightAdd.Text = "<<";
            this.btn_RightAdd.UseVisualStyleBackColor = true;
            this.btn_RightAdd.Click += new System.EventHandler(this.btn_RightAdd_Click);
            // 
            // btn_leftAdd
            // 
            this.btn_leftAdd.Location = new System.Drawing.Point(398, 407);
            this.btn_leftAdd.Name = "btn_leftAdd";
            this.btn_leftAdd.Size = new System.Drawing.Size(50, 30);
            this.btn_leftAdd.TabIndex = 13;
            this.btn_leftAdd.Text = ">>";
            this.btn_leftAdd.UseVisualStyleBackColor = true;
            this.btn_leftAdd.Click += new System.EventHandler(this.btn_leftAdd_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(348, 514);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(100, 45);
            this.btn_Luu.TabIndex = 14;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(616, 514);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 45);
            this.btn_Thoat.TabIndex = 16;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(642, 579);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Website";
            // 
            // lkbl_LienHe
            // 
            this.lkbl_LienHe.AutoSize = true;
            this.lkbl_LienHe.Location = new System.Drawing.Point(717, 578);
            this.lkbl_LienHe.Name = "lkbl_LienHe";
            this.lkbl_LienHe.Size = new System.Drawing.Size(55, 17);
            this.lkbl_LienHe.TabIndex = 17;
            this.lkbl_LienHe.TabStop = true;
            this.lkbl_LienHe.Text = "Liên hệ";
            this.lkbl_LienHe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbl_LienHe_LinkClicked);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Image = global::Lab02_Ex02.Properties.Resources.icons8_cancel_30;
            this.btn_Huy.Location = new System.Drawing.Point(484, 514);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(100, 45);
            this.btn_Huy.TabIndex = 15;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(217, 514);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 45);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(86, 514);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 45);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // FormGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 618);
            this.Controls.Add(this.lkbl_LienHe);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_leftAdd);
            this.Controls.Add(this.btn_RightAdd);
            this.Controls.Add(this.lstb_MonHocDay);
            this.Controls.Add(this.lsb_DsMonHoc);
            this.Controls.Add(this.cklsb_NgoaiNgu);
            this.Controls.Add(this.msktxt_SoDT);
            this.Controls.Add(this.dtpk_NgaySinh);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.rd_Nu);
            this.Controls.Add(this.rd_Nam);
            this.Controls.Add(this.cbb_MaSo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGiaoVien";
            this.Text = "FormGiaoVien";
            this.Load += new System.EventHandler(this.FormGiaoVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_MaSo;
        private System.Windows.Forms.RadioButton rd_Nam;
        private System.Windows.Forms.RadioButton rd_Nu;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.DateTimePicker dtpk_NgaySinh;
        private System.Windows.Forms.MaskedTextBox msktxt_SoDT;
        private System.Windows.Forms.CheckedListBox cklsb_NgoaiNgu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lsb_DsMonHoc;
        private System.Windows.Forms.ListBox lstb_MonHocDay;
        private System.Windows.Forms.Button btn_RightAdd;
        private System.Windows.Forms.Button btn_leftAdd;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel lkbl_LienHe;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Search;
    }
}