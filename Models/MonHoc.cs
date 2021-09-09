using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Ex02.Models
{
    public class MonHoc
    {
        public int ID { get; set; }
        public int SoTC { get; set; }
        public String TenMonHoc { get; set; }

        public MonHoc()
        {
        }

        public MonHoc(int iD, int soTC, string tenMonHoc)
        {
            ID = iD;
            SoTC = soTC;
            TenMonHoc = tenMonHoc;
        }

        public MonHoc(string tenMonHoc)
        {
            TenMonHoc = tenMonHoc;
        }
        public String ToString()
        {
            return TenMonHoc;
        }
    }
}
