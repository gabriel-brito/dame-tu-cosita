using dame_tu_cosita.IO;
using Microsoft.AspNetCore.Mvc;

namespace dame_tu_cosita.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private ActionResult<T> NoAnswer<T>(T data)
        {
            if (data is null)
            {
                return BadRequest();
            }

            return Ok(data);
        }

        [HttpGet]
        public string Get([FromQuery(Name = "id")] int id, [FromQuery(Name = "list")] string list = "asc")
        {
            return "string qualquer";
        }

        [HttpPost]
        public ActionResult<UserOutput> Post([FromBody] UserInput newUser, [FromServices] UseCases.User.Create create)
        {
            var result = create.Execute(newUser);

            return NoAnswer(result);
        }
    }
}
