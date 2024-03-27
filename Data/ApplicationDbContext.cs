using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Euneo.Models;

namespace Euneo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Euneo.Models.Conversation> Conversation { get; set; } = default!;
        public DbSet<Euneo.Models.ConversationType> ConversationType { get; set; } = default!;
    }
}
