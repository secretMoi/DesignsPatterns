using System;

namespace DesignsPatterns.Factory
{
	public class Client
	{
		public void Main()
		{
			Console.WriteLine("App: Launched with the TruckFactory.");
			ClientCode(new TruckFactory());

			Console.WriteLine();

			Console.WriteLine("App: Launched with the ShipFactory.");
			ClientCode(new ShipFactory());

		}

		public void ClientCode(Creator creator)
		{
			Console.WriteLine("Client: I'm not aware of the creator's class, but it still works.\n" + creator.SomeOperation());
		}
	}
}
