using Aurora.Models;
using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Aurora.Data
{
    public class BancoContext(DbContextOptions<BancoContext> options) : DbContext(options)
    {
        public DbSet<EnderecoModel> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EnderecoModel>(entity =>
            {
                entity.ToTable("enderecos", b => b.UseSqlOutputClause(false));

                entity.Property(e => e.UpdatedAt)
                      .HasColumnName("updated_at")
                      .ValueGeneratedOnAddOrUpdate()
                      .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });
        }
    }
}