namespace DesignsPatterns.Factory
{
	public abstract class Creator
	{
		public abstract IProduct FactoryMethod();


		/**
		 * <summary></summary>
		 */
		public string SomeOperation()
		{
			// appelle la méthode factory pour créer l'objet product
			IProduct product = FactoryMethod();

			// utilise le product
			string result = "Creator: The same creator's code has just worked with " + product.Operation();

			return result;
		}
	}
}
