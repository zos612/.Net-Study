using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace EF6_TestApplication
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



            using (var context = new TestContext())
            {

                var query = from user in context.Set<User>()
                            join emp in context.Set<Emp>()
                                on user.user_seq equals emp.user_seq
                            select new { user, emp };

                foreach (var item in query)
                {
                    Console.WriteLine(item.emp.emp_no);
                    Console.WriteLine(item.user.username);
                }
                
            }

        }
    }
}
