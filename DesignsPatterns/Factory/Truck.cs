using System;

namespace DesignsPatterns.Factory
{
	public class Truck : IProduct
	{
		public string Operation()
		{
			return "{Result of Truck}";
		}
	}
}
