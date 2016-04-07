using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Blog.Models
{
    public class BlogDbContext : IdentityDbContext<ApplicationUser>
    {
        public BlogDbContext()
            : base("BlogContext", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<Article> Article { get; set; }

        public static BlogDbContext Create()
        {
            return new BlogDbContext();
        }
    }
}