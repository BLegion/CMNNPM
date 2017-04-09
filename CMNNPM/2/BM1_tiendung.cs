using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMNNPM.BM1
{
    public partial class BM1_tiendung : Form
    {
        public BM1_tiendung()
        {
            InitializeComponent();
        }

        private void BM1_tiendung_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbTenSanh;
        }
    }
}
