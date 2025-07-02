using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinApp.sysBase
{
    public partial class frmDashboard : Form
    {
        sysBase.ConsumeServerAPI c = new sysBase.ConsumeServerAPI();
        MySqlDataAdapter da;
        DataTable dt = new DataTable();

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_empStaff_Click(object sender, EventArgs e)
        {
            menuMasters.frmEmpMaster a = new menuMasters.frmEmpMaster();
            a.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            a.StartPosition = FormStartPosition.CenterParent;
            a.ShowDialog();
            a.Dispose();
        }

        private void btn_docStaff_Click(object sender, EventArgs e)
        {
            menuMasters.frmDocMaster a = new menuMasters.frmDocMaster();
            a.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            a.StartPosition = FormStartPosition.CenterParent;
            a.ShowDialog();
            a.Dispose();
        }

        private void btn_hospital_Click(object sender, EventArgs e)
        {
            menuMasters.frmHospitalMaster a = new menuMasters.frmHospitalMaster();
            a.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            a.StartPosition = FormStartPosition.CenterParent;
            a.ShowDialog();
            a.Dispose();
        }

        private void btn_disease_Click(object sender, EventArgs e)
        {
            menuMasters.frmDiseaseMaster a = new menuMasters.frmDiseaseMaster();
            a.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            a.StartPosition = FormStartPosition.CenterParent;
            a.ShowDialog();
            a.Dispose();
        }

        private void btn_familyInfo_Click(object sender, EventArgs e)
        {
            menuMasters.frmFamilyMaster a = new menuMasters.frmFamilyMaster();
            a.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            a.StartPosition = FormStartPosition.CenterParent;
            a.ShowDialog();
            a.Dispose();
        }

        private void btn_serviceHistory_Click(object sender, EventArgs e)
        {
            menuMasters.frmServiceHistory a = new menuMasters.frmServiceHistory();
            a.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            a.StartPosition = FormStartPosition.CenterParent;
            a.ShowDialog();
            a.Dispose();
        }
    }
}
