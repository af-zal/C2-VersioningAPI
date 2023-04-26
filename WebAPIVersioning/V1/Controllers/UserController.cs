using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIVersioning.Models;

namespace WebAPIVersioning.V1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            var usersDomainModel = UsersData.Get();

            var response = new List<UserDtoV1>();

            foreach(var userDomain in usersDomainModel)
            {
                response.Add(new UserDtoV1
                {
                    Id =userDomain.Id,
                    Name = userDomain.Name
                });
            }

            return Ok(response);
        }
    }
}
