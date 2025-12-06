using ZombieSurvivalGame.Data;
using ZombieSurvivalGame.Domain;
using ZombieSurvivalGame.Domain.Characters;
using ZombieSurvivalGame.Domain.Structures;
using ZombieSurvivalGame.Model;
using ZombieSurvivalGame.Utils;

namespace ZombieSurvivalGame.Services
{
    internal class CharacterService
    {
        private ConsoleHelper consoleHelper;
        private CharacterRepository characterRepository;

        public CharacterService()
        {
            consoleHelper = new ConsoleHelper();
            characterRepository = new CharacterRepository();
        }

        public void ManageCharacters()
        {
            int choice = consoleHelper.ShowCharacterManagementOptions();

            switch (choice)
            {
                case 0:
                    CharacterHelper.HandleCreateCharacter();
                    break;
                case 1:
                    CharacterHelper.HandleLoadCharacter();
                    break;
                case 2:
                    CharacterHelper.HandleDeleteCharacter();
                    break;
                case 3:
                    // Return to main menu
                    break;
                default:
                    Console.WriteLine("Returning to main menu.");
                    break;
            }
        }

        public void SaveCharacter(Character character)
        {
            characterRepository.SaveCharacter(character);
        }

        public List<Character> LoadCharacters()
        {
            return characterRepository.LoadCharacters();
        }

        public bool DeleteCharacter(int characterId)
        {
            return characterRepository.DeleteCharacter(characterId);
        }
    }
}
