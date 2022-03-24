using Microsoft.AspNetCore.Mvc;
using Service;

namespace UserManagementAPI.Controllers
{ 
    [ApiController]
    [Route("[controller]")]
    public class UserController:ControllerBase
    {
        IUserService userService;
        public UserController( IUserService userService)
        {
            this.userService=userService;
        }

        [HttpGet("Users")]
        public ActionResult GetUserDetails()
        {
            return Ok(userService.GetUsers());
        }
        
    }
}