using Microsoft.EntityFrameworkCore;

namespace WebAppDBA.Models
{
    public class WABookStoreContext: DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Books> Books { get; set; }


        public WABookStoreContext(DbContextOptions<WABookStoreContext> options) : base(options)
        {

        }

    }
}
