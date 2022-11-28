using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigYamlTest
{
	public class Configurator
	{
		private IConfigurationRoot Data;

		public Configurator()
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(AppContext.BaseDirectory)
				.AddYamlFile("Config.yaml");
			Data = builder.Build();
		}

		public IConfigurationRoot GetData() => Data;
	}
}
