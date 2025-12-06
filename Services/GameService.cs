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
            consoleHelper.ShowGameTitle();

            while (start)
            {
                // INTRO
                int menuChoice = consoleHelper.ShowMainMenu();

                switch (menuChoice)
                {
                    case 0:
                        // New game logic here
                        // Character management
                        Console.Clear();
                        Console.WriteLine("╔════════════════════════════════════════╗");
                        Console.WriteLine("║           MANAGE CHARACTERS            ║");
                        Console.WriteLine("╚════════════════════════════════════════╝\n");
                        characterService.ManageCharacters();
                        break;
                    case 1:
                        //Campaign mode logic here
                        Console.Clear();
                        Console.WriteLine("╔════════════════════════════════════╗");
                        Console.WriteLine("║         CAMPAIGN MODE STORY        ║");
                        Console.WriteLine("╚════════════════════════════════════╝\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HOLD 'SPACE' TO SPEED UP");
                        Console.ResetColor();

                        ConsoleHelper.TypeEffect("Suddenly, a strange virus infects people in the city, transforming them into zombies, fast, aggressive, and mutated, as though a nightmare manifested itself in reality. You are a messenger that is accustomed to live in a hurry and is familiar with all shortcuts, tunnels, and shadows.");
                        ConsoleHelper.TypeEffect("As communication towers are collapsing one after another, you have to provide a critical antiviral sample before the military will decide to firebomb the whole city to put the outbreak in check.\r\n");
                        ConsoleHelper.TypeEffect("Squeezing through deserted streets, broken houses and underground tunnels, you are not only avoiding various forms of infection, you are also dealing with survivors who are now losing hope.");
                        ConsoleHelper.TypeEffect("Some of them come with you, and each has his talents and tragic histories, and in addition to all those, fears and desperation which are going to divide your camp.\r\n");
                        ConsoleHelper.TypeEffect("As you get further in you get more tragedies: teammates you have to leave behind to allow others to survive, rescue missions that go terribly astray, and tough decisions that haunt your conscience.");
                        ConsoleHelper.TypeEffect("With all the sacrifice, weariness and uncertainty, you start discovering the real cause of the outbreak- and the staggering fact that you were the very one the virus was targeting at the dawn of time.\r\n");

                        Thread.Sleep(2000);
                        ConsoleHelper.TypeEffect("Press any key to continue...");
                        Console.ReadKey();

                        break;
                    case 2:
                        // Credits logic here
                        Console.Clear();
                        Console.WriteLine("╔════════════════════════════════════╗");
                        Console.WriteLine("║              CREDITS               ║");
                        Console.WriteLine("╚════════════════════════════════════╝\n");
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
                    case 3:
                        start = false;
                        break;
                }
            }
            ConsoleHelper.TypeEffect("Thanks for using this program!");

        }
    }
}

