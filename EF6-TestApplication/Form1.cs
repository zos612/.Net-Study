﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;

namespace EF6_TestApplication
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            EF6_TestApplication.TestContext dbContext = new EF6_TestApplication.TestContext();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.tb_emps.Load();
            // This line of code is generated by Data Source Configuration Wizard
            tb_empsBindingSource.DataSource = dbContext.tb_emps.Local.ToBindingList();
        }
    }
}
