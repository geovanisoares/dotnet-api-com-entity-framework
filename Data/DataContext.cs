using dotnet_api_com_entity_framework.Model;
using Microsoft.EntityFrameworkCore;

namespace dotnet_api_com_entity_framework.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
