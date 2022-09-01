using dotnet_api.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;


namespace dotnet_api.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]
  public class CharacterController : ControllerBase
  {
    private readonly ICharacterService _characterService;
    public CharacterController(ICharacterService characterService)
    {
      _characterService = characterService;
    }

    [HttpGet("get-all")]
    public ActionResult<List<Character>> FetchAll()
    {
      return Ok(_characterService.FetchAll());
    }

    [HttpGet("{id}")]
    public ActionResult<List<Character>> FetchById(int id)
    {
      return Ok(_characterService.FetchById(id));
    }

    [HttpPost]
    public ActionResult<Character> Create(Character newCharacter)
    {
      return Ok(_characterService.Create(newCharacter));
    }
  }
}