namespace dotnet_api.Services.CharacterService
{
  public class CharacterService : ICharacterService
  {
    private static List<Character> characters = new List<Character>
    {
        new Character(),
        new Character { Id = 1, Name = "Alucard" }
    };
    public Character Create(Character newCharacter)
    {
      characters.Add(newCharacter);
      return newCharacter;
    }

    public List<Character> FetchAll()
    {
      return characters;
    }

    public Character FetchById(int id)
    {
      return characters.FirstOrDefault(c => c.Id == id);
    }
  }
}