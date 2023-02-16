using APIMysql.Models;
using Microsoft.EntityFrameworkCore;

namespace APIMysql.Data
{
    public class APIDbcontext : DbContext
    {
        public APIDbcontext(DbContextOptions<APIDbcontext> options) : base(options)
        {
        }
        public DbSet<Estado> Estado { get; set; } 
    }
}
