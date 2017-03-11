using Microsoft.AspNetCore.Mvc;
using nz.geek.colin.examples.dotnet.data;
using nz.geek.colin.examples.dotnet.models;
using System.Collections.Generic;

namespace nz.geek.colin.examples.dotnet.controllers
{
	[Route("api/[controller]")]
	public class ValuesController
	{
		private readonly ValueContext _context;

		public ValuesController(ValueContext context) {
			_context = context;
		}

		[HttpGet]
		public IEnumerable<Value> Get()
		{
			return _context.Values;
		}
	}
}
