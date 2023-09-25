using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_đềthithử
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtThongTinSinhVien_Click(object sender, EventArgs e)
        {
            string hovaten = "Nguyen Hoang Thai";
            string mssv = "123456789";
            string monthi = "Lap trinh Window 2  - C#";

            lblInfo.Text = "ho va ten: " + hovaten;
            lblInfo.Text += "\n MSSV: " + mssv;
            lblInfo.Text += "\n ngay thi: " + System.DateTime.Now.ToString();
            lblInfo.Text += "\n mon thi: " + monthi;
        }
    }
}
