using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ChoThueSanVanTruot.Models
{
    public partial class Login : DbContext
    {
        public Login()
            : base("name=Login")
        {
        }
       public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
