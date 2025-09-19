using Aurora.Models;
using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Aurora.Data
{
    public class BancoContext(DbContextOptions<BancoContext> options) : DbContext(options)
    {

    }

        public DbSet<Models.EnderecoModel> Enderecos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar a tabela "enderecos"
            modelBuilder.Entity<EnderecoModel>(entity =>
            {
                entity.ToTable("enderecos", b => b.UseSqlOutputClause(false)); // 🔹 Desabilita OUTPUT para evitar erro com trigger

                // Configura o campo updated_at como gerado pelo banco
                entity.Property(e => e.UpdatedAt)
                      .HasColumnName("updated_at")
                      .ValueGeneratedOnAddOrUpdate()
                      .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });
        }
    }
}
