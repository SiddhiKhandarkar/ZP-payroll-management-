using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinApp.menuMasters
{
    public partial class frmDiseaseMaster : Form
    {
        public frmDiseaseMaster()
        {
            InitializeComponent();
        }

        private void frmDiseaseMaster_Load(object sender, EventArgs e)
        {

        }

        private void btn_regDisease_Click(object sender, EventArgs e)
        {
            regMasters.frmRegDisease a = new regMasters.frmRegDisease();
            a.ShowDialog();
            a.Dispose();
        }
    }
}
