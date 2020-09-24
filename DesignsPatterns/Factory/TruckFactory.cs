namespace DesignsPatterns.Factory
{
	public class TruckFactory : Creator
	{
		public override IProduct FactoryMethod()
		{
			return new Truck();
		}
	}
}
