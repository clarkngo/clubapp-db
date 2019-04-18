using Microsoft.EntityFrameworkCore;

namespace RazorPagesPost.Models
{
    public class RazorPagesPostContext : DbContext
    {
        public RazorPagesPostContext (DbContextOptions<RazorPagesPostContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesPost.Models.Post> Post { get; set; }
    }
}
