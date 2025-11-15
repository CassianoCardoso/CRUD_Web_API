using Microsoft.EntityFrameworkCore;
using WEBAPI.Models;

namespace WEBAPI.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> option) : base(option)   
        {
            
        }

        public DbSet<ProdutoModel> Produtos{ get; set; }
    }
}
