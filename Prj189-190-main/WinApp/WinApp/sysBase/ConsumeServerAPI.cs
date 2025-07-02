using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace WinApp.sysBase
{
    public class ConsumeServerAPI
    {
        //public MySqlConnection cn = new MySqlConnection("Server=115.96.168.103;Port=3306;Database=payrolldb;Uid=prj189;Pwd=prj189@payroll");
        public MySqlConnection cn = new MySqlConnection("Server=115.96.168.103;Port=3306;Database=medicaldb;Uid=prj190;Pwd=prj190@medical");
    }
}