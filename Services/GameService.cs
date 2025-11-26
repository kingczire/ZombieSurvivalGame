using ZombieSurvivalGame.Data;
using ZombieSurvivalGame.Model;
using ZombieSurvivalGame.Utils;

namespace ZombieSurvivalGame.Services
{
    public class GameService
    {
        private CharacterService characterService;
        private CharacterRepository characterRepository;
        private Character character;
        private ConsoleHelper consoleHelper;

        public GameService()
        {
            characterService = new CharacterService();
            characterRepository = new CharacterRepository();
            consoleHelper = new ConsoleHelper();
        }

        public void Start()
        {
            bool start = true;
            while (start)
            {
                // INTRO
                int menuChoice = GetMenuChoice("Select an option: ", 0, 4);

                switch (menuChoice)
                {
                    case 0:
                        // Exit
                        start = false;
                        break;
                    case 1:
                        // New game logic here
                        // Create character
                        character = characterService.GetCharacterFeatures();

                        // Save Character to DB
                        characterRepository.SaveCharacter(character);

                        character.DisplayCharacterInfo();

                        Console.WriteLine("\n╔════════════════════════════════════════╗");
                        Console.WriteLine("║             CHARACTER ACTIONS            ║");
                        Console.WriteLine("╚════════════════════════════════════════╝\n");
                        // Demonstrate character actions
                        character.Attack();
                        character.Attack(character.Equipment.Weapon);
                        character.MakeSound(character.Role);

                        ConsoleHelper.TypeEffect("Press any key to continue...");
                        Console.ReadKey();

                        break;
                    case 2:
                        // Load game logic here
                        ConsoleHelper.TypeEffect("Load Game selected.");
                        List<Character> characters = characterRepository.LoadCharacters();

                        if (characters.Count == 0)
                        {
                            ConsoleHelper.TypeEffect("No saved characters found.");

                            ConsoleHelper.TypeEffect("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        }

                        ConsoleHelper.TypeEffect("Select a character to load:");
                        for (int i = 0; i < characters.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {characters[i].Name} - {characters[i].Role}");
                        }

                        int charChoice = Validator.GetValidNumber("Enter the number of the character to load: ", 1, characters.Count);
                        Character selectedCharacter = characters[charChoice - 1];

                        ConsoleHelper.TypeEffect($"Character {selectedCharacter.Name} loaded successfully!");
                        selectedCharacter.DisplayCharacterInfo();

                        Console.WriteLine("\n╔════════════════════════════════════════╗");
                        Console.WriteLine("║             CHARACTER ACTIONS            ║");
                        Console.WriteLine("╚════════════════════════════════════════╝\n");
                        // Demonstrate character actions
                        selectedCharacter.Attack();
                        selectedCharacter.Attack(selectedCharacter.Equipment.Weapon);
                        selectedCharacter.MakeSound(selectedCharacter.Role);

                        ConsoleHelper.TypeEffect("Press any key to continue...");
                        Console.ReadKey();

                        break;
                    case 3:
                        // Campaign mode logic here
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HOLD 'SPACE' TO SPEED UP");
                        Console.ResetColor();

                        ConsoleHelper.TypeEffect("Suddenly, a strange virus infects people in the city, transforming them into zombies, fast, aggressive, and mutated, as though a nightmare manifested itself in reality. You are a messenger that is accustomed to live in a hurry and is familiar with all shortcuts, tunnels, and shadows.");
                        ConsoleHelper.TypeEffect("As communication towers are collapsing one after another, you have to provide a critical antiviral sample before the military will decide to firebomb the whole city to put the outbreak in check.\r\n");
                        ConsoleHelper.TypeEffect("Squeezing through deserted streets, broken houses and underground tunnels, you are not only avoiding various forms of infection, you are also dealing with survivors who are now losing hope.");
                        ConsoleHelper.TypeEffect("Some of them come with you, and each has his talents and tragic histories, and in addition to all those, fears and desperation which are going to divide your camp.\r\n");
                        ConsoleHelper.TypeEffect("As you get further in you get more tragedies: teammates you have to leave behind to allow others to survive, rescue missions that go terribly astray, and tough decisions that haunt your conscience.");
                        ConsoleHelper.TypeEffect("With all the sacrifice, weariness and uncertainty, you start discovering the real cause of the outbreak- and the staggering fact that you were the very one the virus was targeting at the dawn of time.\r\n");

                        ConsoleHelper.TypeEffect("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 4:
                        // Credits logic here
                        Console.ForegroundColor = ConsoleColor.Red;
                        ConsoleHelper.TypeEffect("Czire Haber");
                        Console.ResetColor();
                        Console.WriteLine(" - Siya ang leader ng group namin. Siya ang nakaisip ng mga idea na pwedeng ilagay para sa program namin. Nag ayos ng magiging flow ng gagawin laro namin at nag bigay ng mga task saamin upang lahat kami ay may magawa para sa aming program.\nSiya ang nag-aayos ng core systems at sinisigurado na gumagana ang lahat, at kung may problema sa code, siya ang go-to ng buong team. Hindi niya hinahayaan na may mga members na hindi nakakasunod at handa nya itong tulungan agad upang matuto at maayos.");
                        Thread.Sleep(1500);

                        Console.ForegroundColor = ConsoleColor.Blue;
                        ConsoleHelper.TypeEffect("Cyril Alferez");
                        Console.ResetColor();
                        Console.WriteLine(" - Siya ang nagbibigay din ng idea, suggestion para sa aming program. Tinutulungan din niya ang pagbuo ng documentation upang mas malinaw ang flow at implementasyon ng program.\nKilala siya sa kanyang creative thinking sa pagbibigay ng idea at kakayahang magmungkahi ng mga solusyon na nagpadali rin sa development process. Isa siya sa pagiging maasahan at madaling makipag-collaborate sa ibang miyembro ng team.\r");
                        Thread.Sleep(1500);

                        Console.ForegroundColor = ConsoleColor.Green;
                        ConsoleHelper.TypeEffect("Jireh Mikael Siojo");
                        Console.ResetColor();
                        Console.WriteLine(" - Siya naman ay nagbibigay siya ng mga idea para sa pagpapabuti ng gameplay at mechanics ng laro, at tumutulong sa iba't ibang gawain upang masiguro ang maayos na progreso ng proyekto.\nAng kanyang naibibigay na tulong sa ideya at actual na trabaho ay nakakatulong sa pag aayos ng laro at sa maayos na flow ng trabaho sa program.\r\n");

                        ConsoleHelper.TypeEffect("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
            ConsoleHelper.TypeEffect("Thanks for using this program!");

        }

        private int GetMenuChoice(string prompt, int min, int max)
        {
            consoleHelper.MenuOptions();
            return Validator.GetValidNumber(prompt, min, max);
        }
    }
}

