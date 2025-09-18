using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;

namespace Aurora.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<Models.EnderecoModel> Enderecos { get; set; }
    }
}
