using ZombieSurvivalGame.Domain;
using ZombieSurvivalGame.Domain.Characters;
using ZombieSurvivalGame.Domain.Structures;
using ZombieSurvivalGame.Model;
using ZombieSurvivalGame.Services;

namespace ZombieSurvivalGame.Utils
{
    public static class CharacterHelper
    {
        private static CharacterService characterService = new CharacterService();
        private static ConsoleHelper consoleHelper = new ConsoleHelper();

        public static void HandleCreateCharacter()
        {
            ConsoleHelper.DisplayCreateCharacterHeader();

            // GetCharacterFeatures to create a character
            Character newCharacter = GetCharacterFeatures();

            AnimationHelper.SimulatedLoading("Saving your character...", "Character created and saved successfully!\n");

            characterService.SaveCharacter(newCharacter);

            AnimationHelper.SimulatedLoading("Loading your character...", "Character loaded successfully!\n");

            newCharacter.DisplayCharacterInfo(newCharacter);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void HandleLoadCharacter()
        {
            ConsoleHelper.DisplayLoadCharacterHeader();

            AnimationHelper.SimulatedLoading("Loading saved characters...", "Characters loaded successfully!\n");
            List<Character> characters = characterService.LoadCharacters();

            if (characters.Count == 0)
            {
                ConsoleHelper.TypeEffect("No saved characters found.");

                ConsoleHelper.TypeEffect("Press any key to continue...");
                Console.ReadKey();
                return;
            }


            ConsoleHelper.DisplayLoadCharacterHeader();
            consoleHelper.DisplayCharacters(characters);

            int charChoice = Validator.GetValidNumber("Enter the number of the character to load: ", 0, characters.Count, () =>
            {
                ConsoleHelper.DisplayLoadCharacterHeader();
                consoleHelper.DisplayCharacters(characters);
            });
            if (charChoice == 0)
            {
                // Return to character management menu
                return;
            }
            Character selectedCharacter = characters[charChoice - 1];

            AnimationHelper.SimulatedLoading("Loading your character...", "Character loaded successfully!\n");

            selectedCharacter.DisplayCharacterInfo(selectedCharacter);

            ConsoleHelper.TypeEffect("Press any key to continue...");
            Console.ReadKey();
        }

        public static void HandleDeleteCharacter()
        {
            ConsoleHelper.DisplayDeleteCharacterHeader();

            AnimationHelper.SimulatedLoading("Loading saved characters...", "Characters loaded successfully!\n");
            List<Character> characters = characterService.LoadCharacters();
            
            if (characters.Count == 0)
            {
                ConsoleHelper.TypeEffect("No saved characters found.");
                ConsoleHelper.TypeEffect("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            ConsoleHelper.DisplayDeleteCharacterHeader();

            consoleHelper.DisplayCharacters(characters);

            int deleteChoice = Validator.GetValidNumber("Enter the number of the character to delete: ", 0, characters.Count, () =>
            {
                ConsoleHelper.DisplayDeleteCharacterHeader();
                consoleHelper.DisplayCharacters(characters);
            });

            if (deleteChoice == 0)
            {
                // Return to character management menu
                return;
            }

            Character characterToDelete = characters[deleteChoice - 1];

            // Confirmation prompt
            ConsoleHelper.DisplayConfirmDeletionHeader();
            
            Console.WriteLine($"Character: {characterToDelete.Name} ({characterToDelete.Role})");
            Console.WriteLine("!!WARNING: This action cannot be undone!");
            Console.WriteLine();

            bool confirmDelete = Validator.GetValidBoolean("Are you sure you want to delete this character? (yes/no): ", () =>
            {
                ConsoleHelper.DisplayConfirmDeletionHeader();

                Console.WriteLine($"Character: {characterToDelete.Name} ({characterToDelete.Role})");
                Console.WriteLine("!!WARNING: This action cannot be undone!");
                Console.WriteLine();
            });

            if (!confirmDelete)
            {
                Console.Clear();
                ConsoleHelper.SuccessMessage("Deletion cancelled. Character was not deleted.");
                ConsoleHelper.TypeEffect("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            // Perform deletion
            try
            {
                AnimationHelper.SimulatedLoading("Deleting character...", "");
                bool success = characterService.DeleteCharacter(characterToDelete.Id);
                
                if (success)
                {
                    Console.Clear();
                    ConsoleHelper.SuccessMessage($"Character '{characterToDelete.Name}' has been successfully deleted.");
                }
                else
                {
                    Console.Clear();
                    ConsoleHelper.ErrorMessage("Failed to delete character. Character may not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                ConsoleHelper.ErrorMessage($"Error occurred while deleting character: {ex.Message}");
            }

            ConsoleHelper.TypeEffect("Press any key to continue...");
            Console.ReadKey();
        }

        private static Character GetCharacterFeatures()
        {
            // Basic Info
            string username = GetUsername();
            string role = GetRole();
            bool isHuman = role.Equals("Human", StringComparison.OrdinalIgnoreCase);
            int age = GetAge();

            // Appearance
            string eyeType = GetChoice("Choose your eye type: ", CharacterParts.EyeTypes, consoleHelper.EyeTypeOptions);
            string eyeColor = GetRoleBasedChoice("Choose your eye color: ", role, isHuman,
                CharacterParts.EyeColorTypeHuman, CharacterParts.EyeColorTypeZombie, consoleHelper.EyeColorOptions);
            string eyebrowColor = GetRoleBasedChoice("Choose your eyebrow color: ", role, isHuman,
                CharacterParts.EyebrowColorTypeHuman, CharacterParts.EyebrowColorTypeZombie, consoleHelper.EyeBrowColorOptions);
            string noseType = GetChoice("Choose your nose type: ", CharacterParts.NoseTypes, consoleHelper.NoseTypeOptions);
            string mouthType = GetChoice("Choose your mouth type: ", CharacterParts.MouthTypes, consoleHelper.MouthTypeOptions);
            string hairStyle = GetRoleBasedChoice("Choose your hair style: ", role, isHuman,
                CharacterParts.HairStyleHuman, CharacterParts.HairStyleZombie, consoleHelper.HairStyleOptions);
            string facialHair = GetRoleBasedChoice("Choose your facial hair: ", role, isHuman,
                CharacterParts.FacialHairTypeHuman, CharacterParts.FacialHairTypeZombie, consoleHelper.FacialHairOptions);
            string facialHairColor = GetRoleBasedChoice("Choose your facial hair color: ", role, isHuman,
                CharacterParts.FacialHairColorTypeHuman, CharacterParts.FacialHairColorTypeZombie, consoleHelper.FacialHairColorOptions);
            string scarsType = GetRoleBasedChoice("Choose your scars type: ", role, isHuman,
                CharacterParts.ScarsTypeHuman, CharacterParts.ScarsTypeZombie, consoleHelper.ScarsTypeOptions);
            string bodyType = GetRoleBasedChoice("Choose your body type: ", role, isHuman,
                CharacterParts.BodyTypeHuman, CharacterParts.BodyTypeZombie, consoleHelper.BodyTypeOptions);
            string skinColor = GetRoleBasedChoice("Choose your skin color: ", role, isHuman,
                CharacterParts.SkinColorHuman, CharacterParts.SkinColorZombie, consoleHelper.SkinColorOptions);
            string posture = GetRoleBasedChoice("Choose your posture type: ", role, isHuman,
                CharacterParts.PostureTypeHuman, CharacterParts.PostureTypeZombie, consoleHelper.PostureOptions);

            // Apparel
            string hat = GetRoleBasedChoice("Choose your hat type: ", role, isHuman,
                CharacterParts.HatTypeHuman, CharacterParts.HatTypeZombie, consoleHelper.HatTypeOptions);
            string shirt = GetRoleBasedChoice("Choose your shirt type: ", role, isHuman,
                CharacterParts.ShirtTypeHuman, CharacterParts.ShirtTypeZombie, consoleHelper.ShirtTypeOptions);
            string jacket = GetRoleBasedChoice("Choose your jacket type: ", role, isHuman,
                CharacterParts.JacketTypeHuman, CharacterParts.JacketTypeZombie, consoleHelper.JacketTypeOptions);
            string pantsType = GetRoleBasedChoice("Choose your pants type: ", role, isHuman,
                CharacterParts.PantsTypeHuman, CharacterParts.PantsTypeZombie, consoleHelper.PantsTypeOptions);
            string gloves = GetRoleBasedChoice("Choose your gloves type: ", role, isHuman,
                CharacterParts.GlovesTypeHuman, CharacterParts.GlovesTypeZombie, consoleHelper.GlovesTypeOptions);
            string boots = GetRoleBasedChoice("Choose your boots type: ", role, isHuman,
                CharacterParts.BootsTypeHuman, CharacterParts.BootsTypeZombie, consoleHelper.BootsTypeOptions);

            // Equipment
            string armor = GetRoleBasedChoice("Choose your armor type: ", role, isHuman,
                CharacterParts.ArmorTypeHuman, CharacterParts.ArmorTypeZombie, consoleHelper.ArmorTypeOptions);
            string tattoo = GetChoice("Choose your tattoo type: ", CharacterParts.TattooTypes, consoleHelper.TattoosOptions);
            string weaponType = GetRoleBasedChoice("Choose your weapon type: ", role, isHuman,
                CharacterParts.WeaponTypeHuman, CharacterParts.WeaponTypeZombie, consoleHelper.WeaponTypeOptions);

            // Stealth
            bool isStealthy = GetStealthChoice(isHuman);

            // objects
            Appearance appearance = new Appearance(
                eyeType, eyeColor, eyebrowColor, noseType, mouthType,
                hairStyle, facialHair, facialHairColor, scarsType,
                bodyType, skinColor, posture
            );

            Apparel apparel = new Apparel(hat, shirt, jacket, pantsType, gloves, boots);

            Equipment equipment = new Equipment(armor, tattoo, weaponType);

            // final result
            if (isHuman)
                return new Human(role, username, age, appearance, apparel, equipment, isStealthy);

            return new Zombie(role, username, age, appearance, apparel, equipment, isStealthy);
        }

        // Helper Methods
        private static string GetUsername()
        {
            string username = Validator.GetValidUsername("Enter username: ", () =>
            {
                ConsoleHelper.DisplayCreateCharacterHeader();
                Console.WriteLine("Enter username: ");
            });
            Console.Clear();
            return username;
        }

        private static string GetRole()
        {
            ConsoleHelper.CharacterRoleOptions();
            string selectedRoleText = CharacterParts.RoleType[
                Validator.GetValidNumber("Choose your role: ", 1, CharacterParts.RoleType.Length, 
                    () => ConsoleHelper.CharacterRoleOptions()) - 1
            ];
            
            Console.WriteLine("ROLE: " + selectedRoleText);
            string role = selectedRoleText.Split("-")[0].Trim();
            Console.Clear();
            return role;
        }

        private static int GetAge()
        {
            ConsoleHelper.AgeOptions();
            int age = CharacterParts.Ages[
                Validator.GetValidNumber("Enter your age: ", 1, CharacterParts.Ages.Length, 
                    () => ConsoleHelper.AgeOptions()) - 1
            ];
            Console.Clear();
            return age;
        }

        private static string GetChoice(string prompt, string[] options, Action displayMethod)
        {
            displayMethod();
            string choice = options[
                Validator.GetValidNumber(prompt, 1, options.Length, displayMethod) - 1
            ];
            Console.Clear();
            return choice;
        }

        private static string GetRoleBasedChoice(string prompt, string role, bool isHuman, 
            string[] humanOptions, string[] zombieOptions, Action<string> displayMethod)
        {
            displayMethod(role);
            string[] selectedOptions = isHuman ? humanOptions : zombieOptions;
            string choice = selectedOptions[
                Validator.GetValidNumber(prompt, 1, selectedOptions.Length, 
                    () => displayMethod(role)) - 1
            ];
            Console.Clear();
            return choice;
        }

        private static bool GetStealthChoice(bool isHuman)
        {
            if (!isHuman) return false;
            
            consoleHelper.StealthOptions();
            bool isStealthy = Validator.GetValidBoolean("Do you want stealth perks? (yes/no): ", 
                () => consoleHelper.StealthOptions());
            Console.Clear();
            return isStealthy;
        }

    }
}
