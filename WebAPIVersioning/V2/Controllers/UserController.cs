using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIVersioning.Models;

namespace WebAPIVersioning.V2.Controllers
{
    [Route("api/v2/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            var usersDomainModel = UsersData.Get();

            var response = new List<UserDtoV2>();

            foreach(var userDomain in usersDomainModel)
            {
                response.Add(new UserDtoV2
                {
                    Id =userDomain.Id,
                    Username = userDomain.Name
                });
            }

            return Ok(response);
        }
    }
}
