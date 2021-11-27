using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLGiaoVien.Models
{
    public partial class DBGiaoVienContext : DbContext
    {
        public DBGiaoVienContext()
            : base("name=DBGiaoVienConnectionString")
        {
        }

        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>()
                .HasMany(e => e.GiaoViens)
                .WithOptional(e => e.ChucVu)
                .HasForeignKey(e => e.IdChucVu);
        }
    }
}
