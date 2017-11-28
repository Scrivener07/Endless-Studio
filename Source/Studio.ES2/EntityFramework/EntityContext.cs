using ES2.Amplitude;
using ES2.Amplitude.Unity.Runtime;
using System.Data.Entity;

namespace Studio.EntityFramework
{
	public class EntityContext : DbContext
	{
		public DbSet<RuntimeModule> RuntimeModules { get; set; }
		public DbSet<RuntimePlugin> RuntimePlugins { get; set; }
		public DbSet<Tags> Tags { get; set; }
	}
}
