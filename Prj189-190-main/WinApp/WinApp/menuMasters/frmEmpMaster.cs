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
    public partial class frmEmpMaster : Form
    {
        public frmEmpMaster()
        {
            InitializeComponent();
        }

        private void btn_regEmployee_Click(object sender, EventArgs e)
        {
            regMasters.frmRegEmp a = new regMasters.frmRegEmp();
            a.ShowDialog();
            a.Dispose();
        }
    }
}
