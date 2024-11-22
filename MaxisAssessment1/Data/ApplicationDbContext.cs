using Microsoft.EntityFrameworkCore;
using MaxisAssessment1.Models;

namespace MaxisAssessment1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<ContactSubmission> ContactSubmissions { get; set; }
    }
}
