using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Ex02.Models
{
    public class GiaoVien
    {
        public DanhMucMonHoc dsMonHoc;
        public string GioiTinh;
        public string Mail;
        public DateTime NgaySinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string HoTen { get; set; }
        public string MaSo { get; set; }

        public GiaoVien()
        {
            dsMonHoc = new DanhMucMonHoc();
            NgoaiNgu = new string[10];
        }

        public GiaoVien(DanhMucMonHoc dsMonHoc, string gioiTinh, string mail, DateTime ngaySinh, string[] ngoaiNgu, string soDT, string hoTen, string maSo)
        {
            this.dsMonHoc = dsMonHoc;
            GioiTinh = gioiTinh;
            Mail = mail;
            NgaySinh = ngaySinh;
            NgoaiNgu = ngoaiNgu;
            SoDT = soDT;
            HoTen = hoTen;
            MaSo = maSo;
        }
        public override string ToString()
        {
            String s = "Mã số: \t" + MaSo + "\n" + "Họ Tên: \t" + HoTen + "\n" + "Ngày Sinh: \t" + NgaySinh + "\n" +
                "Giới Tính: \t" + GioiTinh + "\n" + "Số ĐT: \t" + SoDT + "\n" + "Mail: \t" + Mail + "\n";
            string strsNgoaiNgu = "Ngoại Ngữ: \t";
            for(int i =0; i<NgoaiNgu.Length; i++)
            {
                if (i == NgoaiNgu.Length - 1)
                    strsNgoaiNgu += NgoaiNgu[i].Trim();
                else
                    strsNgoaiNgu += NgoaiNgu[i].Trim() + ',';
            }
           
            string strsMonHoc = "Môn Học: \t\t";
            for(int i =0; i<dsMonHoc.ds.Count; i++)
            {
                if (i == dsMonHoc.ds.Count - 1)
                    strsMonHoc += dsMonHoc.ds[i].ToString();
                else
                    strsMonHoc += dsMonHoc.ds[i].ToString() + ',';
            }
            
            s += strsNgoaiNgu + "\n" + strsMonHoc;
            return s;
        }
    }
}
