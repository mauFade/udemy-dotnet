namespace dotnet_api.Services.CharacterService
{
  public interface ICharacterService
  {
    List<Character> FetchAll();

    Character FetchById(int id);

    Character Create(Character newCharacter);
  }
}