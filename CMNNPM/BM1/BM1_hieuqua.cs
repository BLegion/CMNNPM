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
    public partial class BM1_hieuqua : Form
    {
        public BM1_hieuqua()
        {
            InitializeComponent();
        }

        private void BM1_hieuqua_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbTenSanh;
            //tbToiThieu.TabIndex = ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
