namespace Studio.EntityFramework
{

	public class Product
	{
		public int ProductId { get; set; }
		public string Name { get; set; }

		public ColorType Color { get; set; }
		public int Weight { get; set; }

		public int CategoryId { get; set; }
		public virtual Category Category { get; set; }

		public Product()
		{
			Color = ColorType.Blue;
			Weight = 0;
		}
	}


	public class Category
	{
		private readonly ObservableListSource<Product> _products = new ObservableListSource<Product>();

		public int CategoryId { get; set; }
		public string Name { get; set; }
		public virtual ObservableListSource<Product> Products { get { return _products; } }
	}


	public enum ColorType
	{
		Red,
		Green,
		Blue
	}


}
