using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using MySql.Data.MySqlClient;
using System.Data;

namespace Dapper_TestApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //BonusSkins.Register();
            //Application.Run(new Form1());

            using (var connection = new MySqlConnection("server=106.252.242.26;port=3309;database=rmsdb;uid=heatmaster;password=rpn123!!##")
            {
                
                //var guid = Guid.NewGuid();
                //var dog = connection.Query("select Age = @Age, Id = @Id", new { Age = (int?)null, Id = guid });
            }

                

        }

        
    }

    public class test
    {

        public static MySqlConnection GetOpenConnection()
        {
            string connectionString = "server=106.252.242.26;port=3309;database=rmsdb;uid=heatmaster;password=rpn123!!##";

            var connection = new MySqlConnection(connectionString);

            connection.Open();

            return connection;
        }
    }

    public class Emp
    {
        public int user_seq { get; set; }
        public string emp_no { get; set; }
        public string emp_nm { get; set; }

        //public virtual ICollection<User> Users { get; set; }
    }
    
    public class User
    {
        public int user_seq { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public List<Emp> Emps { get; set; }
    }
}
