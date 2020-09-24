namespace DesignsPatterns.Bridge
{
	public class ConcreteImplementationB : IImplementation
	{
		public string OperationImplementation()
		{
			return "ConcreteImplementationB : resultat dans la plateforme B.\n";
		}
	}
}
