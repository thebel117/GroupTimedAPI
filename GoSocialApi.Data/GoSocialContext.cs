using GoSocialApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GoSocialApi.Data
{
    public class GoSocialContext : DbContext
    {
        public GoSocialContext(DbContextOptions<GoSocialContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Like> Likes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Gotta configure the relationships, constraints, misc bullshit
        }
    }
}
