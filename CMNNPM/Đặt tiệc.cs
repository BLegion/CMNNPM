using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMNNPM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            DanhSachThucPham form = new DanhSachThucPham();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DanhSachThucPham mForm = new DanhSachThucPham();
            mForm.Show();
            mForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
        }
    }
}
