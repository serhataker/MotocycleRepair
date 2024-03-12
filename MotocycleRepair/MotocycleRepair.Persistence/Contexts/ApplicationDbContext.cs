using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotocycleRepair.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Veritabanı tabloları için DbSet tanımlamaları
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Part> Parts { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubPart> SubParts { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierPart> SupplierParts { get; set; }
        public DbSet<SupplierSubPart> SupplierSubParts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Özelleştirilmiş yapılandırmalar ve ilişkiler burada tanımlanabilir.
            // Örneğin, birçok-bir veya birçok-birçok ilişkileri.

            // Product ile Customer arasındaki ilişkiyi yapılandırma
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Customer)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CustomerId);

            // Process ile Product arasındaki ilişkiyi yapılandırma
            modelBuilder.Entity<Process>()
                .HasOne(pr => pr.Product)
                .WithMany(p => p.Processes)
                .HasForeignKey(pr => pr.ProductId);

            // SubPart ile Part arasındaki ilişkiyi yapılandırma
            modelBuilder.Entity<SubPart>()
                .HasOne(sp => sp.Part)
                .WithMany(p => p.SubParts)
                .HasForeignKey(sp => sp.PartId);

            // SupplierPart ile Part ve Supplier arasındaki ilişkileri yapılandırma
            modelBuilder.Entity<SupplierPart>()
                .HasOne(sp => sp.Part)
                .WithMany()
                .HasForeignKey(sp => sp.PartId);

            modelBuilder.Entity<SupplierPart>()
                .HasOne(sp => sp.Supplier)
                .WithMany()
                .HasForeignKey(sp => sp.SupplierId);

            // SupplierSubPart ile SubPart ve Supplier arasındaki ilişkileri yapılandırma
            modelBuilder.Entity<SupplierSubPart>()
                .HasOne(ssp => ssp.SubPart)
                .WithMany()
                .HasForeignKey(ssp => ssp.SubPartId);

            modelBuilder.Entity<SupplierSubPart>()
                .HasOne(ssp => ssp.Supplier)
                .WithMany()
                .HasForeignKey(ssp => ssp.SupplierId);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }

        public override int SaveChanges()
        {
            return SaveChangesAsync().GetAwaiter().GetResult();
        }
    }
}
