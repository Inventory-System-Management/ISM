using ISM.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM.Infrastructure.ISMDbcontext
{
    public class ISMdbcontext:DbContext
    {
        public ISMdbcontext()
        {
            
        }
        public ISMdbcontext(DbContextOptions<ISMdbcontext>options):base(options) 
        {
            
        }
       public DbSet<Material> Materials { get; set; }
       public DbSet<Order> Orders { get; set; }
       public DbSet<Order_Detail> OrderDetails { get; set; }
       public  DbSet<Role> Roles { get; set; }
       public DbSet<Storage> Storages { get; set; }
       public  DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=::1;Port=5432;Database=Hello;user id=postgres;password=123456");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>()
          .HasIndex(m => m.Id);

            modelBuilder.Entity<Order>()
                .HasIndex(o => o.Id);

            modelBuilder.Entity<Order_Detail>()
                .HasIndex(od => od.Id);

            modelBuilder.Entity<Role>()
                .HasIndex(r => r.Id);

            modelBuilder.Entity<Storage>()
                .HasIndex(s => s.Id);

            modelBuilder.Entity<Supplier>()
                .HasIndex(s => s.Id);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
