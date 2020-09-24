using System;
using DesignsPatterns.Observer;

namespace DesignsPatterns
{
	public class Run
	{
		public Run()
		{
			Observer();

			Console.ReadLine();
		}

		public void Observer()
		{
			// permet à des objets de s'inscrire à des events d'un autre objet
			// permet d'éviter de boucler périodiquement pour checker l'état

			Subject subject = new Subject();

			ObserverA observerA = new ObserverA();
			subject.Attach(observerA);

			ObserverB observerB = new ObserverB();
			subject.Attach(observerB);

			subject.SomeWork();
			subject.SomeWork();

			subject.Detach(observerB);

			subject.SomeWork();
		}

	}
}
