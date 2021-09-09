using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Ex02.Models
{
    public class DanhMucMonHoc
    {
        public List<MonHoc> ds;
        public MonHoc this[int index]
        {
            get { return ds[index] as MonHoc; }
            set { ds[index] = value; }
        }

        public DanhMucMonHoc()
        {
            ds = new List<MonHoc>();
        }
        public void ThemMonHoc(MonHoc mh)
        {
            ds.Add(mh);
        }
        public String ToString()
        {
            string str = "";
            foreach (var mh in ds)
                str += mh.ToString() + ';';
            return str;
        }
    }
}
