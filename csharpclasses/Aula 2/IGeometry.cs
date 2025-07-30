using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpclasses.Aula_2
{
	// Interface é um contrato
	internal interface IGeometry
	{
		public string Name { get; set; }

		public string GetName();
	}
}
