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
    public partial class frmDocMaster : Form
    {
        public frmDocMaster()
        {
            InitializeComponent();
        }

        private void frmDocMaster_Load(object sender, EventArgs e)
        {

        }

        private void btn_regDoctor_Click(object sender, EventArgs e)
        {
            regMasters.frmRegDoctor a = new regMasters.frmRegDoctor();
            a.ShowDialog();
            a.Dispose();
        }
    }
}
