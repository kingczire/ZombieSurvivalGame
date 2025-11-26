using ZombieSurvivalGame.Domain;
using ZombieSurvivalGame.Domain.Characters;
using ZombieSurvivalGame.Domain.Structures;
using ZombieSurvivalGame.Model;
using ZombieSurvivalGame.Utils;

namespace ZombieSurvivalGame.Services
{
    internal class CharacterService
    {
        public Character GetCharacterFeatures()
        {
            ConsoleHelper consoleHelper = new ConsoleHelper();
            Console.Clear();

            Console.WriteLine("========== CHARACTER CREATION ==========");

            // username
            string username = Validator.GetValidUsername("Enter username: ");
            Console.Clear();

            // role
            ConsoleHelper.CharacterRoleOptions();
            string selectedRoleText = CharacterParts.RoleType[
                Validator.GetValidNumber("Choose your role: ", 1, CharacterParts.RoleType.Length) - 1
            ];

            Console.WriteLine("ROLE: " + selectedRoleText);
            string role = selectedRoleText.Split("-")[0].Trim();
            bool isHuman = role.Equals("Human", StringComparison.OrdinalIgnoreCase);

            // age
            ConsoleHelper.AgeOptions();
            int age = CharacterParts.Ages[
                Validator.GetValidNumber("Enter your age: ", 1, CharacterParts.Ages.Length) - 1
            ];
            Console.Clear();

            // APPEARANCE
            string eyeType = AskChoice("Choose your eye type: ",
                CharacterParts.EyeTypes,
                consoleHelper.EyeTypeOptions);
            Console.Clear();

            string eyeColor = AskChoice("Choose your eye color: ",
                isHuman ? CharacterParts.EyeColorTypeHuman : CharacterParts.EyeColorTypeZombie,
                () => consoleHelper.EyeColorOptions(role));
            Console.Clear();

            string eyebrowColor = AskChoice("Choose your eyebrow color: ",
                isHuman ? CharacterParts.EyebrowColorTypeHuman : CharacterParts.EyebrowColorTypeZombie,
                () => consoleHelper.EyeBrowColorOptions(role));
            Console.Clear();

            string noseType = AskChoice("Choose your nose type: ",
                CharacterParts.NoseTypes,
                consoleHelper.NoseTypeOptions);
            Console.Clear();

            string mouthType = AskChoice("Choose your mouth type: ",
                CharacterParts.MouthTypes,
                consoleHelper.MouthTypeOptions);
            Console.Clear();

            string hairStyle = AskChoice("Choose your hair style: ",
                isHuman ? CharacterParts.HairStyleHuman : CharacterParts.HairStyleZombie,
                () => consoleHelper.HairStyleOptions(role));
            Console.Clear();

            string facialHair = AskChoice("Choose your facial hair: ",
                isHuman ? CharacterParts.FacialHairTypeHuman : CharacterParts.FacialHairTypeZombie,
                () => consoleHelper.FacialHairOptions(role));
            Console.Clear();

            string facialHairColor = AskChoice("Choose your facial hair color: ",
                isHuman ? CharacterParts.FacialHairColorTypeHuman : CharacterParts.FacialHairColorTypeZombie,
                () => consoleHelper.FacialHairColorOptions(role));
            Console.Clear();

            string scarsType = AskChoice("Choose your scars type: ",
                isHuman ? CharacterParts.ScarsTypeHuman : CharacterParts.ScarsTypeZombie,
                () => consoleHelper.ScarsTypeOptions(role));
            Console.Clear();

            string bodyType = AskChoice("Choose your body type: ",
                isHuman ? CharacterParts.BodyTypeHuman : CharacterParts.BodyTypeZombie,
                () => consoleHelper.BodyTypeOptions(role));
            Console.Clear();

            string skinColor = AskChoice("Choose your skin color: ",
                isHuman ? CharacterParts.SkinColorHuman : CharacterParts.SkinColorZombie,
                () => consoleHelper.SkinColorOptions(role));
            Console.Clear();

            string posture = AskChoice("Choose your posture type: ",
                isHuman ? CharacterParts.PostureTypeHuman : CharacterParts.PostureTypeZombie,
                () => consoleHelper.PostureOptions(role));
            Console.Clear();

            // APPAREL
            string hat = AskChoice("Choose your hat type: ",
                isHuman ? CharacterParts.HatTypeHuman : CharacterParts.HatTypeZombie,
                () => consoleHelper.HatTypeOptions(role));
            Console.Clear();

            string shirt = AskChoice("Choose your shirt type: ",
                isHuman ? CharacterParts.ShirtTypeHuman : CharacterParts.ShirtTypeZombie,
                () => consoleHelper.ShirtTypeOptions(role));
            Console.Clear();

            string jacket = AskChoice("Choose your jacket type: ",
                isHuman ? CharacterParts.JacketTypeHuman : CharacterParts.JacketTypeZombie,
                () => consoleHelper.JacketTypeOptions(role));
            Console.Clear();

            string pantsType = AskChoice("Choose your pants type: ",
                isHuman ? CharacterParts.PantsTypeHuman : CharacterParts.PantsTypeZombie,
                () => consoleHelper.PantsTypeOptions(role));
            Console.Clear();

            string gloves = AskChoice("Choose your gloves type: ",
                isHuman ? CharacterParts.GlovesTypeHuman : CharacterParts.GlovesTypeZombie,
                () => consoleHelper.GlovesTypeOptions(role));
            Console.Clear();

            string boots = AskChoice("Choose your boots type: ",
                isHuman ? CharacterParts.BootsTypeHuman : CharacterParts.BootsTypeZombie,
                () => consoleHelper.BootsTypeOptions(role));
            Console.Clear();

            // EQUIPMENT
            string armor = AskChoice("Choose your armor type: ",
                isHuman ? CharacterParts.ArmorTypeHuman : CharacterParts.ArmorTypeZombie,
                () => consoleHelper.ArmorTypeOptions(role));
            Console.Clear();

            string tattoo = AskChoice("Choose your tattoo type: ",
                CharacterParts.TattooTypes,
                () => consoleHelper.TattoosOptions());
            Console.Clear();

            string weaponType = AskChoice("Choose your weapon type: ",
                isHuman ? CharacterParts.WeaponTypeHuman : CharacterParts.WeaponTypeZombie,
                () => consoleHelper.WeaponTypeOptions(role));
            Console.Clear();

            // stealth
            consoleHelper.StealthOptions(role);
            bool isStealthy = Validator.GetValidBoolean("Do you want stealth perks? (yes/no): ");
            Console.Clear();

            // objects
            Appearance appearance = new Appearance(
                eyeType, eyeColor, eyebrowColor, noseType, mouthType,
                hairStyle, facialHair, facialHairColor, scarsType,
                bodyType, skinColor, posture);

            Apparel apparel = new Apparel(hat, shirt, jacket, pantsType, gloves, boots);

            Equipment equipment = new Equipment(armor, tattoo, weaponType);

            // final result
            if (isHuman)
                return new Human(role, username, age, appearance, apparel, equipment, isStealthy);

            return new Zombie(role, username, age, appearance, apparel, equipment, isStealthy);
        }

        private string AskChoice(string prompt, string[] options, Action showOptions)
        {
            showOptions?.Invoke();
            int choice = Validator.GetValidNumber(prompt, 1, options.Length);
            return options[choice - 1];
        }
    }
}
