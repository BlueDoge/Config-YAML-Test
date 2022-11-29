using System;
using System.Collections.Generic;
using System.IO;
using ConfigYamlTest;
using Microsoft.Extensions.Configuration;

namespace ConfigYamlTest
{
	public class Program
	{
		static void Main(string[] args)
		{
			var config = new Configurator();
			var data = config.GetData();
			Console.WriteLine(data.GetDebugView());
			Console.WriteLine("...");

			// post all the names, idk just a test of functionality
			data.GetSection("test").GetChildren().ToList().ForEach(child => Console.WriteLine(child["name"]));
		}
	}
}
