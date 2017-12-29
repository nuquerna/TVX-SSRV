using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using SLInterface;

namespace tvx_ssrv.Controllers
{
    [ValidationModel]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> PostUser([FromBody]User user)
        {
            return Ok(await _userService.AddNewUser(user));     
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> PutUser([FromBody]User user)
        {
            await _userService.UpdateUser(user);
            return Ok();
        }
    }
}