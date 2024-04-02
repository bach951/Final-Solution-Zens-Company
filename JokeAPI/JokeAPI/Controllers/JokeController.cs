using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JokeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        [HttpGet("get-joke-contents")]
        public IActionResult Get()
        {
            JokeDBContext db = new JokeDBContext();
           var jokeContents = db.Content.ToList();
            return Ok(jokeContents);
        }

        [HttpGet("get-joke-content/{id}")]
        public IActionResult GetJokeContentById([FromRoute] int id)
        {
            JokeDBContext db = new JokeDBContext();
            var jokeContent = db.Content.SingleOrDefault(x => x.ID == id);
            return Ok(jokeContent);
        }
    }
}
