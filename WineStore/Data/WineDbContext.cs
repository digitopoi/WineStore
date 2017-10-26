using WineStore.Models;
using System.Data.Entity;

namespace WineStore.Models
{
    public class WineDbContext : DbContext
    {
        public DbSet<Wine> Wines { get; set; }
    }
}