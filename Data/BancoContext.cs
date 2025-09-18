using Microsoft.EntityFrameworkCore;

namespace Aurora.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
    }
}
