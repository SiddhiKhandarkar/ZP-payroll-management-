using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinApp.menuMasters
{
    public partial class frmServiceHistory : Form
    {
        public frmServiceHistory()
        {
            InitializeComponent();
        }

        private void btn_regHeadOffice_Click(object sender, EventArgs e)
        {
            regMasters.frmRegHeadOffice a = new regMasters.frmRegHeadOffice();
            a.ShowDialog();
            a.Dispose();
        }

        private void btn_regSubOffice_Click(object sender, EventArgs e)
        {
            regMasters.frmRegSubOffice a = new regMasters.frmRegSubOffice();
            a.ShowDialog();
            a.Dispose();
        }
    }
}
