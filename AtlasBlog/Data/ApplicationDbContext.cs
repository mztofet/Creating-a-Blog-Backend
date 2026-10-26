using AtlasBlog.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AtlasBlog.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blogs => Set<Blog>();

        public DbSet<Post> Posts => Set<Post>();

        public DbSet<Comment> Comments => Set<Comment>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Blog>()
                .HasMany(b => b.Posts)
                .WithOne(p => p.Blog)
                .HasForeignKey(p => p.BlogId);

            builder.Entity<Post>()
                .HasMany(p => p.Comments)
                .WithOne(c => c.Post)
                .HasForeignKey(c => c.PostId);
        }
    }
}