using ecommerce.services.order.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.services.order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersController()
        { }

        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> PostAsync([FromBody] User user)
        {
           
            return Created("",user);
        }
    }
}
