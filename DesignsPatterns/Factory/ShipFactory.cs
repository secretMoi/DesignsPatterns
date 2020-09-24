namespace DesignsPatterns.Factory
{
	public class ShipFactory : Creator
	{
		public override IProduct FactoryMethod()
		{
			return new Ship();
		}
	}
}
