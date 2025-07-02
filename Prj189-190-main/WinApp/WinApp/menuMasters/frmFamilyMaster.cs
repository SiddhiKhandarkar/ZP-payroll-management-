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
    public partial class frmFamilyMaster : Form
    {
        public frmFamilyMaster()
        {
            InitializeComponent();
        }

        private void btn_regFamilyMember_Click(object sender, EventArgs e)
        {
            regMasters.frmRegFamilyMember a = new regMasters.frmRegFamilyMember();
            a.ShowDialog();
            a.Dispose();
        }
    }
}
