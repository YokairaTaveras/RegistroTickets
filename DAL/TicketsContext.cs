using Microsoft.EntityFrameworkCore;
using RegistroTickets.Models;

namespace RegistroTickets.DAL
{

    public class TicketsContext : DbContext
    {
        public TicketsContext(DbContextOptions<TicketsContext> Options)
            : base(Options) { }

        public DbSet<Sistemas> Sistemas { get; set; }
    }
}
