using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace todo.Models
{
    public class JegyzetekDbContext : DbContext
    {
        public JegyzetekDbContext(DbContextOptions<JegyzetekDbContext> options) : base(options)
        {
        }

        // Helyes DbSet definíciók
        public DbSet<Jegyzet> Jegyzetek { get; set; }
        public DbSet<Kartya> Kartyak { get; set; }
    }
}
