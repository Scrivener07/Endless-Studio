using System.Data.Entity;

namespace Studio.EntityFramework
{
	public class EntityContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
	}
}
