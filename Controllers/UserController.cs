using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenerateEntity.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> Test()
		{
			return Ok("");

		}
	}
}
