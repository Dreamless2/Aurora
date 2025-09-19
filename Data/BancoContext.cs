using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;

namespace Aurora.Data
{
    public class BancoContext(DbContextOptions<BancoContext> options) : DbContext(options)
    {
        public DbSet<Models.EnderecoModel> Enderecos { get; set; }
    }

}
