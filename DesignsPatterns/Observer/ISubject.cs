namespace DesignsPatterns.Observer
{
	public interface ISubject
	{
		void Attach(IObserver observer); // attache un observer à un subject
		void Detach(IObserver observer); // détache un observer à un subject
		void Notify(); // notifie tous les observers
	}
}
