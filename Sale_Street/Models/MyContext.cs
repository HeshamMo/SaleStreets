using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Sale_Street.Models
{
	public class MyContext:IdentityDbContext<AppUser>
	{
		public MyContext(DbContextOptions<MyContext> options):base(options)
		{

		}

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
	}
}
