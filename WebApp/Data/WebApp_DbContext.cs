using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class WebApp_DbContext : DbContext
    {
        public WebApp_DbContext(DbContextOptions<WebApp_DbContext> options):
            base(options)
        {
            
        }

        public DbSet<WebApp.Models.User> Users { get; set; }
    }
}
