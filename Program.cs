using System;
using System.Collections.Generic;
using System.IO;
using ConfigYamlTest;
using Microsoft.Extensions.Configuration;

namespace BlueDoge.Bot
{
	[Serializable]
	public class CommandLineArgumentsException : Exception
	{
	}

	public class Program
	{
		static void Main(string[] args)
		{
			var config = new Configurator();
			var data = config.GetData();
			Console.WriteLine(data.GetDebugView());
		}
	}
}
