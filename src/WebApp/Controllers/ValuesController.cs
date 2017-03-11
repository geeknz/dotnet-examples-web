using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
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
