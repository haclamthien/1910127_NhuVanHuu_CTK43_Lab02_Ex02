using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab02_Ex02.Models;

namespace Lab02_Ex02
{
    public static class QuanLyGiaoVien
    {
        public static List<GiaoVien> dsGV;

        static QuanLyGiaoVien()
        {
            dsGV = FakeData();
        }
        /*public GiaoVien this[int index]
        {
            get { return dsGV[index] as GiaoVien; }
            set { dsGV[index] = value; }
        }*/
        private static List<GiaoVien> FakeData()
        {
            List<GiaoVien> dsgv = new List<GiaoVien>();
            DanhMucMonHoc dsmh = new DanhMucMonHoc();
            String[] strs = {"Tin học cơ sở","Lập trình cấu trúc C/C++","Cơ sở dữ liệu",
                                "Tiếng Anh B1",
                                "Tiếng Anh B2",
                                "Lập trình hướng đối tượng",
                                "Mạng máy tính",
                                "Công nghệ phần mềm",
                                "Phân tích thiết kế HDT"};

            Random random = new Random();
            dsmh.ThemMonHoc(new MonHoc(strs[random.Next(0, 9)]));
            dsmh.ThemMonHoc(new MonHoc(strs[random.Next(0, 9)]));
            String[] nns = { "Tiếng Anh", "Tiếng Pháp", "Tiếng Nga", "Tiếng Nhật" };

            dsgv.Add(new GiaoVien(dsmh, "Nam", "a@gmail.com", DateTime.ParseExact("14/09/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture), nns, "0971727932", "Nguyên Văn A", "0001"));
            dsgv.Add(new GiaoVien(dsmh, "Nam", "a@gmail.com", DateTime.ParseExact("14/09/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture), nns, "0971727932", "Nguyên Văn B", "0002"));
            dsgv.Add(new GiaoVien(dsmh, "Nam", "a@gmail.com", DateTime.ParseExact("14/09/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture), nns, "0971727932", "Nguyên Văn C", "0003"));
            return dsgv;
        }
        public static bool ThemGiaoVien(GiaoVien gv)
        {
            if (dsGV.FindAll(p => p.MaSo.CompareTo(gv.MaSo) == 0).Count > 0) return false;
            else dsGV.Add(gv);
            return true;
        }

    }
}
