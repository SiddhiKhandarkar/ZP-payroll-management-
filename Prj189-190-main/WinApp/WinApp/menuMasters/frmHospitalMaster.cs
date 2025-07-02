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
    public partial class frmHospitalMaster : Form
    {
        public frmHospitalMaster()
        {
            InitializeComponent();
        }

        private void btn_regHospital_Click(object sender, EventArgs e)
        {
            regMasters.frmRegHospital a = new regMasters.frmRegHospital();
            a.ShowDialog();
            a.Dispose();
        }
    }
}
