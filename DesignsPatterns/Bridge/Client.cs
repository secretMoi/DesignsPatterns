﻿using System;

namespace DesignsPatterns.Bridge
{
	public class Client
	{
		public void ClientCode(Abstraction abstraction)
		{
			Console.WriteLine(abstraction.Operation());
		}
	}
}
