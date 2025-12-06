using ZombieSurvivalGame.Data;
using ZombieSurvivalGame.Domain;
using ZombieSurvivalGame.Model;

namespace ZombieSurvivalGame.Utils
{
    public class ConsoleHelper
    {
        CharacterRepository characterRepository;
        public ConsoleHelper()
        {
            characterRepository = new CharacterRepository();
        }

        public static void DisplayCreateCharacterHeader()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║          CREATE YOUR CHARACTER         ║");
            Console.WriteLine("╚════════════════════════════════════════╝\n");
        }

        public static void DisplayLoadCharacterHeader()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║           LOAD YOUR CHARACTER          ║");
            Console.WriteLine("╚════════════════════════════════════════╝\n");
        }

        public static void DisplayDeleteCharacterHeader()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║         DELETE YOUR CHARACTER          ║");
            Console.WriteLine("╚════════════════════════════════════════╝\n");
        }

        public static void DisplayConfirmDeletionHeader()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║           CONFIRM DELETION             ║");
            Console.WriteLine("╚════════════════════════════════════════╝\n");
        }

        public static void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void SuccessMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect(message);
            Console.ResetColor();
        }

        public void DisplayCharacters(List<Character> characters)
        {
            if (characters == null || characters.Count == 0)
            {
                ConsoleHelper.TypeEffect("No saved characters found.");

                ConsoleHelper.TypeEffect("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            ConsoleHelper.TypeEffect("Select a character:");
            Console.WriteLine("0. Back");
            for (int i = 0; i < characters.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {characters[i].Name} - {characters[i].Role}");
            }
        }

        public void ShowGameTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            string[] titleArt = new string[]
            {
        "██████   ██   ██  ██   ██  ███████  ██   ██      ██████   ███████",
        "██   ██  ██   ██  ██   ██  ██   ██  ██   ██      ██   ██  ██   ██",
        "██████   ██   ██  ███████  ███████  ███████      ██████   ███████",
        "██   ██  ██   ██  ██   ██  ██   ██    ███        ██       ██   ██",
        "██████   ███████  ██   ██  ██   ██    ███        ██       ██   ██"
            };

            int width = titleArt.Max(line => line.Length) + 6; // 3 spaces padding each side

            // Top border
            Console.WriteLine("╔" + new string('═', width) + "╗");

            Console.WriteLine("║" + new string(' ', width) + "║");

            string titleText = "BUHAY PA!";
            int padding = (width - titleText.Length) / 2;
            Console.WriteLine("║" + new string(' ', padding) + titleText + new string(' ', width - padding - titleText.Length) + "║");

            Console.WriteLine("║" + new string(' ', width) + "║");

            foreach (var line in titleArt)
            {
                string paddedLine = line.PadRight(width - 4); // 2 spaces on each side inside border
                Console.WriteLine("║  " + paddedLine + "  ║");
            }

            Console.WriteLine("╚" + new string('═', width) + "╝");

            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);

                int delay = (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar) ? 0 : 30;

                Thread.Sleep(delay);
            }

            Console.WriteLine();
        }

        public int ShowMainMenu()
        {
            string[] options = { "Character Management", "Campaign Mode", "Credits", "Exit" };
            int selectedIndex = 0;
            ConsoleKey key;

            do
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║                MAIN MENU               ║");
                Console.WriteLine("╚════════════════════════════════════════╝\n");

                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"> {options[i]}"); // Highlighted selection
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {options[i]}");
                    }
                }

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex < 0) selectedIndex = options.Length - 1;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex >= options.Length) selectedIndex = 0;
                }

            } while (key != ConsoleKey.Enter);

            return selectedIndex;
        }

        public int ShowCharacterManagementOptions()
        {
            string[] options = { "Create Character", "Load Character", "Delete Character", "Back" };
            int selectedIndex = 0;
            ConsoleKey key;

            do
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║          CHARACTER MANAGEMENT          ║");
                Console.WriteLine("╚════════════════════════════════════════╝\n");

                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"> {options[i]}"); // Highlighted selection
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {options[i]}");
                    }
                }

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex < 0) selectedIndex = options.Length - 1;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex >= options.Length) selectedIndex = 0;
                }

            } while (key != ConsoleKey.Enter);

            return selectedIndex;
        }

        // age
        public static void AgeOptions()
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            for (int i = 0; i < CharacterParts.Ages.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.Ages[i]} - {CharacterParts.AgeDescriptions[i]}");
            }
        }

        // role
        public static void CharacterRoleOptions()
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            for (int i = 0; i < CharacterParts.RoleType.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.RoleType[i]}");
            }
        }

        // eye
        public void EyeTypeOptions()
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            for (int i = 0; i < CharacterParts.EyeTypes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.EyeTypes[i]}");
            }
        }

        // eye color
        public void EyeColorOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.EyeColorTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.EyeColorTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.EyeColorTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.EyeColorTypeZombie[i]}");
                }
            }
        }

        // eyebrow color
        public void EyeBrowColorOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.EyebrowColorTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.EyebrowColorTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.EyebrowColorTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.EyebrowColorTypeZombie[i]}");
                }
            }
        }

        // nose 
        public void NoseTypeOptions()
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            for (int i = 0; i < CharacterParts.NoseTypes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.NoseTypes[i]}");
            }
        }

        // mouth
        public void MouthTypeOptions()
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            for (int i = 0; i < CharacterParts.MouthTypes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.MouthTypes[i]}");
            }
        }

        // hair style
        public void HairStyleOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.HairStyleHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.HairStyleHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.HairStyleZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.HairStyleZombie[i]}");
                }
            }
        }

        //facial hair
        public void FacialHairOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.FacialHairTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.FacialHairTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.FacialHairTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.FacialHairTypeZombie[i]}");
                }
            }
        }

        // facial hair color 
        public void FacialHairColorOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.FacialHairColorTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.FacialHairColorTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.FacialHairColorTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.FacialHairColorTypeZombie[i]}");
                }
            }
        }

        //scars
        public void ScarsTypeOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.ScarsTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.ScarsTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.ScarsTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.ScarsTypeZombie[i]}");
                }
            }
        }

        // body type
        public void BodyTypeOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.BodyTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.BodyTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.BodyTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.BodyTypeZombie[i]}");
                }
            }
        }

        // skin color
        public void SkinColorOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.SkinColorHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.SkinColorHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.SkinColorZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.SkinColorZombie[i]}");
                }
            }
        }

        // posture
        public void PostureOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.PostureTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.PostureTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.PostureTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.PostureTypeZombie[i]}");
                }
            }
        }

        //hats
        public void HatTypeOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.HatTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.HatTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.HatTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.HatTypeZombie[i]}");
                }
            }
        }

        // shirt
        public void ShirtTypeOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.ShirtTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.ShirtTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.ShirtTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.ShirtTypeZombie[i]}");
                }
            }
        }

        // jacket
        public void JacketTypeOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.JacketTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.JacketTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.JacketTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.JacketTypeZombie[i]}");
                }
            }
        }

        // pants
        public void PantsTypeOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human"))
            {
                for (int i = 0; i < CharacterParts.PantsTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.PantsTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.PantsTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.PantsTypeZombie[i]}");
                }
            }
        }

        // gloves
        public void GlovesTypeOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human"))
            {
                for (int i = 0; i < CharacterParts.GlovesTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.GlovesTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.GlovesTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.GlovesTypeZombie[i]}");
                }
            }
        }

        //boots
        public void BootsTypeOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human"))
            {
                for (int i = 0; i < CharacterParts.BootsTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.BootsTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.BootsTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.BootsTypeZombie[i]}");
                }
            }
        }

        //armor
        public void ArmorTypeOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human"))
            {
                for (int i = 0; i < CharacterParts.ArmorTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.ArmorTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.ArmorTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.ArmorTypeZombie[i]}");
                }
            }
        }

        // tattoos
        public void TattoosOptions()
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            for (int i = 0; i < CharacterParts.TattooTypes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.TattooTypes[i]}");
            }
        }

        // weapon
        public void WeaponTypeOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human"))
            {
                for (int i = 0; i < CharacterParts.WeaponTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.WeaponTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.WeaponTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.WeaponTypeZombie[i]}");
                }
            }
        }

        // stealth perks
        public void StealthOptions()
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            for (int i = 0; i < CharacterParts.IsStealthy.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.IsStealthy[i]}");
            }
        }
    }
}


