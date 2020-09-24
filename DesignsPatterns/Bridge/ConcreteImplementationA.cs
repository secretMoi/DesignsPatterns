namespace DesignsPatterns.Bridge
{
	public class ConcreteImplementationA : IImplementation
	{
		public string OperationImplementation()
        {
            return "ConcreteImplementationA : resultat dans la plateform A.\n";
        }
	}
}