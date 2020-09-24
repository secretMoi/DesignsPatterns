using System;

namespace DesignsPatterns.Observer
{
	public class ObserverA : IObserver
	{
		public void Update(ISubject subject)
		{
			Subject evenement = subject as Subject;
			if (evenement.State > 5)
				Console.WriteLine("Ohh the state is > than " + evenement.State);
		}
	}
}
