using Amplitude.Unity.Runtime;
using System.Data.Entity;

namespace Studio.EntityFramework
{
	public class ProductContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
	}
}
