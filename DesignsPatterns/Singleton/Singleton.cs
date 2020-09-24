namespace DesignsPatterns.Singleton
{
	public class Singleton
	{
		private static Singleton _instance; // contient le seul objet possible

		// constructeur privé pour empêcher toute instanciation
		private Singleton()
		{
			
		}

		/**
		 * <summary>Récupère un objet de la classe Singleton</summary>
		 * <returns>Retourne l'instance de la classe Singleton</returns>
		 */
		public static Singleton GetInstance()
		{
			if(_instance == null) // si aucune instance n'a été créée
				_instance = new Singleton(); // on la crée

			return _instance; // retourne la seule instance
		}
	}
}
