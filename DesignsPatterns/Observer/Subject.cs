using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignsPatterns.Observer
{
	public class Subject : ISubject
	{
		public int State { get; set; }

		// liste des subscribers
		private readonly List<IObserver> _observers = new List<IObserver>();

		/**
		 * <summary>Attache un observer</summary>
		 */
		public void Attach(IObserver observer)
		{
			_observers.Add(observer);
		}

		/**
		 * <summary>Détache un observer</summary>
		 */
		public void Detach(IObserver observer)
		{
			_observers.Remove(observer);
		}

		/**
		 * <summary>Notifie tous les observers inscrits</summary>
		 */
		public void Notify()
		{
			foreach (IObserver observer in _observers)
			{
				observer.Update(this); // ils pourront accéder à la variable State
			}
		}

		/**
		 * <summary>Action à exécuter</summary>
		 */
		public void SomeWork()
		{
			Console.WriteLine("Currently hacking NASA using HTML, takes some time...");
			State = new Random().Next(0, 11);

			Thread.Sleep(15);

			Console.WriteLine("Ohhh NASA has been hacked with code " + State);
			Notify();
		}
	}
}
