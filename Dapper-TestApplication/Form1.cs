using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dapper_TestApplication
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();


            test t = new test();

            var db = t.connectionFactory();

            //var emp = Dapper.SqlMapper.Query<Emp>(db, "select * from tb_emp");
            var emp2 = Dapper.SqlMapper.Query<Emp>(db, "select * from tb_emp").ToList<Emp>();

            gridControl1.DataSource = emp2;
        }
    }
}
