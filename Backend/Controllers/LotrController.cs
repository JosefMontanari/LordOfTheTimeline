using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LotrController : ControllerBase
	{
		// GET: api/<LotrController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<LotrController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<LotrController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<LotrController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<LotrController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
