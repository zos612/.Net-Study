namespace EF6_TestApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class TestContext : DbContext
    {
        public DbSet<Emp> tb_emps { get; set; }
        public DbSet<User> users { get; set; }

        public TestContext()
            : base("name=TestContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }

    [Table("tb_emp")]
    public class Emp
    {
        [Key]
        public int user_seq { get; set; }
        public string emp_no { get; set; }
        public string emp_nm { get; set; }
        
        //public virtual ICollection<User> Users { get; set; }
    }

    [Table("tb_users")]
    public class User
    {
        [Key]
        public int user_seq { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public List<Emp> Emps { get; set; }
    }
}