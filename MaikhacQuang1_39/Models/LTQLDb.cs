using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MaikhacQuang1_39.Models
{
    public partial class LTQLDb : DbContext
    {
        public LTQLDb()
            : base("name=LTQLDb")
        {
        }

        public virtual DbSet<PhongBan> PhongBans { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
