using Microsoft.EntityFrameworkCore;

namespace Amazonia.DAL.Modelo
{
    public class AmazoniaContexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Morada> Moradas { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = @$"Server=(LocalDB)\MSSQLLocalDB; Database=AmazoniaTeste;Trusted_Connection=True";
            options.UseSqlServer(connectionString);


            //var connectionString = @$"Data Source=c:\temp\meudb.db";
            //options.UseSqlite(connectionString);
        }
    }
}
