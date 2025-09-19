using Aurora.Models;
using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Aurora.Data
{
    public class BancoContext(DbContextOptions<BancoContext> options) : DbContext(options)
    {
        public DbSet<EnderecoModel> Enderecos { get; set; }
    }
}