using Microsoft.EntityFrameworkCore;

namespace Amazonia.DAL.Modelo
{
    public class AmazoniaContexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Morada> Moradas { get; set; }
    }
}
