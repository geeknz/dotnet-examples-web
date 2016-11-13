using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace nz.geek.colin.examples.dotnet
{
	[Route("api/[controller]")]
	public class ValuesController
	{
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}
	}
}
