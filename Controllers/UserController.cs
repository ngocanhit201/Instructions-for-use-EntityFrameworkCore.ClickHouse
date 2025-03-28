using ClickHouse.Client.ADO;
using GenerateEntity.Models;
using GenerateEntity.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
namespace GenerateEntity.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly MyDbContext _context;
		public UserController(MyDbContext context)
		{
			_context = context;
		}
		[HttpGet]
		public async Task<IActionResult> OneEntity()
		{
			var userQuery = _context.Users.Where(e => e.Name == "four").ToQueryString();

			var result = GodMethods.ExecuteQueryClickhouse<List<User>>(userQuery);

			return Ok(result);

		}
		[HttpGet]
		public async Task<IActionResult> ListEntity()
		{
			var userQuery = _context.Users;

			//var result = GodMethods.ExecuteQueryClickhouse<List<User>>(userQuery);

			return Ok(userQuery);

		}


	}
}
