using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace Studio.EntityFramework
{
	public partial class EntityInitializer : DropCreateDatabaseAlways<EntityContext>
	{

		public override void InitializeDatabase(EntityContext context)
		{
			try
			{
				base.InitializeDatabase(context);
			}
			catch (DbEntityValidationException exception)
			{
				foreach (var result in exception.EntityValidationErrors)
				{
					string name = result.Entry.Entity.GetType().Name;
					var state = result.Entry.State;

					Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:", name, state);

					foreach (var error in result.ValidationErrors)
					{
						string property = error.PropertyName;
						var value = result.Entry.CurrentValues.GetValue<object>(error.PropertyName);
						string message = error.ErrorMessage;

						Debug.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"", property, value, message);
					}
				}

				throw;
			}
		}


		protected override void Seed(EntityContext context)
		{
			context.SeedTables();
			base.Seed(context);
		}

	}
}
