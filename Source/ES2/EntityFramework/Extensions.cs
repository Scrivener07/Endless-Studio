using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ES2.EntityFramework
{
	public static class Extensions
	{

		public static List<string> GetTableNames(this DbContext context)
		{
			return context.GetType().GetProperties()
				.Where(x => x.PropertyType.Name == "DbSet`1")
				.Select(x => x.Name).ToList();
		}


		/// <summary>
		/// Does not call save on context.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="dbSet"></param>
		public static void Clear<T>(this DbSet<T> dbSet) where T : class
		{
			dbSet.RemoveRange(dbSet);
		}


		/// <summary>
		/// Does not call save on context.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="dbSet"></param>
		public static void Clear(this DbSet dbSet)
		{
			dbSet.RemoveRange(dbSet);
		}


	}
}
