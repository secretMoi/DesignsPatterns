using DesignsPatterns.Bridge;
using DesignsPatterns.Observer;
using Console = System.Console;

namespace DesignsPatterns
{
	public class Run
	{
		public Run()
		{
			Factory();

			Console.ReadLine();
		}

		public void Factory()
		{
			new Factory.Client().Main();
		}

		public void Bridge()
		{
            Client client = new Client();

            Abstraction abstraction;

            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);

        }

		public void Observer()
		{
			// permet à des objets de s'inscrire à des events d'un autre objet
			// permet d'éviter de boucler périodiquement pour checker l'état #Hedia #Polling

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
