using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIVersioning.Models;

namespace WebAPIVersioning.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")] //Versions supported by the controller
    public class UserController : ControllerBase
    {
        //api/countries?api-version=1.0
        //api/countries?api-version=2.0
        //have v1, v2 in endpoint instead ?
        ///api/v2.0/user <summary>
        /// api/v2.0/user
        /// </summary>
        /// <returns></returns>
        [MapToApiVersion("1.0")]
        [HttpGet]
        public IActionResult GetV1()
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

        [MapToApiVersion("2.0")]
        [HttpGet]
        public IActionResult GetV2()
        {
            var usersDomainModel = UsersData.Get();

            var response = new List<UserDtoV2>();

            foreach (var userDomain in usersDomainModel)
            {
                response.Add(new UserDtoV2
                {
                    Id = userDomain.Id,
                    Username = userDomain.Name
                });
            }

            return Ok(response);
        }

    }
}
