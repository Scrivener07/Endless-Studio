using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ES2.Editor.Framework
{
	public static class EntityExtensions
	{
		#region DbContext

		/// <summary>
		/// Gets a string list of each DbSet property name within the context.
		/// </summary>
		/// <param name="context">The DbContext to search.</param>
		/// <returns>A string list of context table names.</returns>
		public static List<string> GetTableNames(this DbContext context)
		{
			return context.GetType().GetProperties()
				.Where(x => x.PropertyType.Name == "DbSet`1")
				.Select(x => x.Name).ToList();
		}

		#endregion


		#region DbSet

		/// <summary>
		/// Clears the typed collection of entities from the context underlying the set
		/// with each entity being put into the Deleted state such that it will be deleted
		/// from the database when SaveChanges is called.
		/// </summary>
		/// <typeparam name="T">The type of DbSet to clear.</typeparam>
		/// <param name="dbSet">The DbSet to clear.</param>
		public static void Clear<T>(this DbSet<T> dbSet) where T : class
		{
			dbSet.RemoveRange(dbSet);
		}

		/// <summary>
		/// Clears the collection of entities from the context underlying the set
		/// with each entity being put into the Deleted state such that it will be deleted
		/// from the database when SaveChanges is called.
		/// </summary>
		/// <param name="dbSet">The DbSet to clear.</param>
		/// <remarks>
		/// Note that if System.Data.Entity.Infrastructure.DbContextConfiguration.AutoDetectChangesEnabled
		/// is set to true (which is the default), then DetectChanges will be called once
		/// before delete any entities and will not be called again. This means that in some
		/// situations RemoveRange may perform significantly better than calling Remove multiple
		/// times would do. Note that if any entity exists in the context in the Added state,
		/// then this method will cause it to be detached from the context. This is because
		/// an Added entity is assumed not to exist in the database such that trying to delete it does not make sense.
		/// </remarks>
		public static void Clear(this DbSet dbSet)
		{
			dbSet.RemoveRange(dbSet);
		}

		#endregion


	}
}
