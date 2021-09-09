using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Ex02
{
    public partial class FormTTGiaoVien : Form
    {
        public FormTTGiaoVien()
        {
            InitializeComponent();
        }
        public void SetText(String str)
        {
            this.lbl_TTGiaoVien.Text = str;
        }
    }
}
