using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab02_Ex02.Models;

namespace Lab02_Ex02
{
    public partial class FormSearch : Form
    {
        //private QuanLyGiaoVien qlgv;
        public FormSearch()
        {
            //qlgv = new QuanLyGiaoVien();
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            lbl_hint.Text = "Mã GV";
        }

        private void rd_maso_CheckedChanged(object sender, EventArgs e)
        {
            lbl_hint.Text = "Mã GV";
        }

        private void rd_Hoten_CheckedChanged(object sender, EventArgs e)
        {
            lbl_hint.Text = "Họ Tên GV";
        }

        private void rd_SDT_CheckedChanged(object sender, EventArgs e)
        {
            lbl_hint.Text = "Số ĐT";
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            if (rd_maso.Checked == true)
                gv = QuanLyGiaoVien.dsGV.Find(p => p.MaSo.CompareTo(txt_searchKey.Text) == 0);
            if (rd_Hoten.Checked == true)
                gv = QuanLyGiaoVien.dsGV.Find(p => p.HoTen.CompareTo(txt_searchKey.Text) == 0);
            if (rd_SDT.Checked == true)
                gv = QuanLyGiaoVien.dsGV.Find(p => p.SoDT.CompareTo(txt_searchKey.Text) == 0);
            if(gv ==null)
            {
                MessageBox.Show("Không có kết quả phù hợp", "Thông báo");
            }
            else
            {
                FormTTGiaoVien frm = new FormTTGiaoVien();
                frm.SetText(gv.ToString());
                frm.ShowDialog();
            }
            
        }
    }
}
