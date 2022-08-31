using Microsoft.AspNetCore.Mvc;


namespace dotnet_api.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]
  public class CharacterController : ControllerBase
  {
    private static List<Character> characters = new List<Character>
    {
        new Character(),
        new Character { Name = "Alucard" }
    };

    [HttpGet]
    [Route("get-all")]
    public ActionResult<List<Character>> Get()
    {
      return Ok(characters);
    }

    [HttpGet]
    public ActionResult<List<Character>> GetOne()
    {
      return Ok(characters[0]);
    }

    // [HttpPost]
    // public ActionResult<Character> Create(){
    //     var newCharacter = new Character({})
    // }
  }
}