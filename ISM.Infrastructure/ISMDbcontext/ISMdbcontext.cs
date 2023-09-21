using ISM.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ISM.Infrastructure.ISMDbcontext
{
    public class ISMdbcontext : DbContext
    {
        public ISMdbcontext() { }
        public ISMdbcontext(DbContextOptions<ISMdbcontext> options) : base(options) { }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Detail> OrderDetails { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseNpgsql("Server=::1;Port=5432;Database=ism;User id=postgres;password=763m44c44V");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Order>()
                .HasKey(o => o.Id);

            modelBuilder.Entity<Order_Detail>()
                .HasKey(od => od.Id);

            modelBuilder.Entity<Role>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<Storage>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Supplier>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
