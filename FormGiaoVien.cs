using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab02_Ex02.Models;

namespace Lab02_Ex02
{
    public partial class FormGiaoVien : Form
    {
       // private QuanLyGiaoVien qlgv;
        public FormGiaoVien()
        {
            //qlgv = new QuanLyGiaoVien();
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            String lienhe = "https://it.dlu.edu.vn/e-learning/Default.aspx";
            lkbl_LienHe.Links.Add(0, lienhe.Length, lienhe);
            LoadMaSoToCbb();
            cbb_MaSo.SelectedItem = this.cbb_MaSo.Items[0];
            loadTTGVByMaSo(cbb_MaSo.Items[0].ToString());
        }
        private void LoadMaSoToCbb()
        {
            cbb_MaSo.Items.Clear();
            foreach (GiaoVien gv in QuanLyGiaoVien.dsGV)
            {
                cbb_MaSo.Items.Add(gv.MaSo);
            }
        }
        private void ClearDsNgoaiNgu()
        {
            for (int i = 0; i < cklsb_NgoaiNgu.Items.Count; i++)
            {
                cklsb_NgoaiNgu.SetItemChecked(i, false);
            }
        }
        private void loadTTGVByMaSo(string maso)
        {
            GiaoVien gv = QuanLyGiaoVien.dsGV.Find(p => p.MaSo.CompareTo(maso) == 0);
            txt_HoTen.Text = gv.HoTen;
            msktxt_SoDT.Text = gv.SoDT;
            txt_Email.Text = gv.Mail;
            if (gv.GioiTinh == "Nam") rd_Nam.Checked = true;
            if (gv.GioiTinh == "Nữ") rd_Nu.Checked = true;
            dtpk_NgaySinh.Value = gv.NgaySinh;
            ClearDsNgoaiNgu();
            foreach(string nn in gv.NgoaiNgu)
            {
                for(int i =0; i<cklsb_NgoaiNgu.Items.Count; i++)
                {
                    if(cklsb_NgoaiNgu.Items[i].ToString() == nn)
                    {
                        cklsb_NgoaiNgu.SetItemChecked(i, true);
                    }
                }
            }
            lstb_MonHocDay.Items.Clear();
            ListBox.ObjectCollection items = lsb_DsMonHoc.Items;
            foreach(MonHoc mh in gv.dsMonHoc.ds)
            {
                lstb_MonHocDay.Items.Add(mh.ToString());
                if (items.Contains(mh.ToString()))
                    items.Remove(mh.ToString());
            }
        }

        private void btn_leftAdd_Click(object sender, EventArgs e)
        {
            int i = this.lsb_DsMonHoc.SelectedItems.Count - 1;
            while (i >= 0)
            {
                lstb_MonHocDay.Items.Add(lsb_DsMonHoc.SelectedItems[i]);
                this.lsb_DsMonHoc.Items.Remove(lsb_DsMonHoc.SelectedItems[i]);
                i--;
            }
        }

        private void btn_RightAdd_Click(object sender, EventArgs e)
        {
            int i = this.lstb_MonHocDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                
                this.lsb_DsMonHoc.Items.Add(lstb_MonHocDay.SelectedItems[i]);
                lstb_MonHocDay.Items.Remove(lstb_MonHocDay.SelectedItems[i]);
                i--;
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            ReSet();
        }

        private void ReSet()
        {
            cbb_MaSo.Text = "";
            txt_HoTen.Text = "";
            txt_Email.Text = "";
            msktxt_SoDT.Text = "";
            rd_Nam.Checked = false;
            rd_Nu.Checked = false;
            for (int i = 0; i < cklsb_NgoaiNgu.Items.Count; i++)
                cklsb_NgoaiNgu.SetItemChecked(i, false);
            foreach (object ob in lstb_MonHocDay.Items)
                lsb_DsMonHoc.Items.Add(ob);
            this.lstb_MonHocDay.Items.Clear();
            dtpk_NgaySinh.Value = DateTime.Now;
        }

        private void lkbl_LienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            FormTTGiaoVien frm = new FormTTGiaoVien();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
            
            int index = QuanLyGiaoVien.dsGV.FindIndex(p => p.MaSo.CompareTo(GetGiaoVien().MaSo) == 0);
            
            
            QuanLyGiaoVien.dsGV[index] = GetGiaoVien();

        }
        public GiaoVien GetGiaoVien()
        {
            GiaoVien gv = new GiaoVien();
            gv.MaSo = cbb_MaSo.Text;
            if (rd_Nam.Checked == true) gv.GioiTinh = "Nam";
            if (rd_Nu.Checked == true) gv.GioiTinh = "Nữ";
            gv.HoTen = txt_HoTen.Text;
            gv.SoDT = msktxt_SoDT.Text;
            gv.NgaySinh = dtpk_NgaySinh.Value;
            gv.Mail = txt_Email.Text;
            string strsNgoaiNgu = "";
            for (int i = 0; i < cklsb_NgoaiNgu.Items.Count; i++)
                if (cklsb_NgoaiNgu.GetItemChecked(i))
                    strsNgoaiNgu+= cklsb_NgoaiNgu.Items[i].ToString()+";";
            gv.NgoaiNgu = strsNgoaiNgu.Split(';');
            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach (object ob in lstb_MonHocDay.Items)
                mh.ThemMonHoc(new MonHoc(ob.ToString()));
            gv.dsMonHoc = mh;

                return gv;
        }

        private void cbb_MaSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTTGVByMaSo(cbb_MaSo.SelectedItem.ToString());
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cbb_MaSo.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Lỗi Thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GiaoVien gv = GetGiaoVien();
            
            if (QuanLyGiaoVien.ThemGiaoVien(gv) == true)
            {
                MessageBox.Show("Thêm giáo viên thành công", "Thông báo");
                LoadMaSoToCbb();
                loadTTGVByMaSo(cbb_MaSo.Text);
            }
            else
                MessageBox.Show("Giáo viên đã tồn tại", "Thông báo");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            FormSearch frm = new FormSearch();
            frm.ShowDialog();
        }
    }
}
