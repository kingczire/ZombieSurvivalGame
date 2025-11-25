using ZombieSurvivalGame.Domain;
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
            string username = Validator.GetValidInput("Enter username: ");
            Console.Clear();

            // role
            ConsoleHelper.CharacterRoleOptions();
            string role = CharacterParts.RoleType[Validator.GetValidNumber("Choose your role: ", 1, 2) - 1];
            Console.Clear();

            // age
            ConsoleHelper.AgeOptions();
            int ageChoice = Validator.GetValidNumber("Enter your age: ", 1, 4);
            int age = CharacterParts.Ages[ageChoice - 1];
            Console.Clear();

            // eye type
            //consoleHelper.EyeTypeOptions();
            //string eyeType = CharacterParts.EyeTypes[Validator.GetValidNumber("Choose your eye type: ", 1, CharacterParts.EyeTypes.Length) - 1];
            string eyeType = AskChoice("Choose your eye type: ", CharacterParts.EyeTypes, consoleHelper.EyeTypeOptions);
            Console.Clear();

            // eye colors 
            string[] eyeColorOptions = role == "Human" ? CharacterParts.EyeColorTypeHuman : CharacterParts.EyeColorTypeZombie;
            string eyeColor = AskChoice("Choose your eye color: ", eyeColorOptions, () => consoleHelper.EyeColorOptions(role));
            Console.Clear();

            //eyebrow color
            string[] eyebrowColorOptions = role == "Human" ? CharacterParts.EyebrowColorTypeHuman : CharacterParts.EyebrowColorTypeZombie;
            string eyebrowColor = AskChoice("Choose your eyebrow color: ", eyebrowColorOptions, () => consoleHelper.EyeBrowColorOptions(role));
            Console.Clear();

            // NOTE: The following sections follow a similar pattern above.
            // nose type 
            consoleHelper.NoseTypeOptions();
            string noseType = CharacterParts.NoseTypes[Validator.GetValidNumber("Choose your nose type: ", 1, CharacterParts.NoseTypes.Length) - 1];
            Console.Clear();

            // mouse type
            consoleHelper.MouthTypeOptions();
            string mouthType = CharacterParts.MouthTypes[Validator.GetValidNumber("Choose your mouth type: ", 1, CharacterParts.MouthTypes.Length) - 1];
            Console.Clear();

            // hair style
            string hairStyle;
            consoleHelper.HairStyleOptions(role);

            if (role.Equals("Human"))
            {
                hairStyle = CharacterParts.HairStyleHuman[Validator.GetValidNumber("Choose your hairstyle: ", 1, CharacterParts.HairStyleHuman.Length) - 1];
            }
            else
            {
                hairStyle = CharacterParts.HairStyleZombie[Validator.GetValidNumber("Choose your hairstyle: ", 1, CharacterParts.HairStyleZombie.Length) - 1];
            }
            Console.Clear();

            // facial hair
            consoleHelper.FacialHairOptions(role);
            string facialHair = "";
            if (role.Equals("Human"))
            {
                facialHair = CharacterParts.FacialHairTypeHuman[Validator.GetValidNumber("Choose your Facial Hair: ", 1, CharacterParts.FacialHairTypeHuman.Length) - 1];
            }
            else
            {
                facialHair = CharacterParts.FacialHairTypeZombie[Validator.GetValidNumber("Choose your Facial Hair: ", 1, CharacterParts.FacialHairTypeZombie.Length) - 1];
            }
            Console.Clear();

            //facial hair color 
            consoleHelper.FacialHairColorOptions(role);
            string facialHairColor = "";
            if (role.Equals("Human"))
            {
                facialHairColor = CharacterParts.FacialHairColorTypeHuman[Validator.GetValidNumber("Choose your Facial Hair Color: ", 1, CharacterParts.FacialHairColorTypeHuman.Length) - 1];
            }
            else
            {
                facialHairColor = CharacterParts.FacialHairColorTypeZombie[Validator.GetValidNumber("Choose your Facial Hair Color: ", 1, CharacterParts.FacialHairColorTypeZombie.Length) - 1];
            }
            Console.Clear();

            //scars type
            consoleHelper.ScarsTypeOptions(role);
            string scarsType = "";
            if (role.Equals("Human"))
            {
                scarsType = CharacterParts.ScarsTypeHuman[Validator.GetValidNumber("Choose your Scars Type: ", 1, CharacterParts.ScarsTypeHuman.Length) - 1];
            }
            else
            {
                scarsType = CharacterParts.ScarsTypeZombie[Validator.GetValidNumber("Choose your Scars Type: ", 1, CharacterParts.ScarsTypeZombie.Length) - 1];
            }
            Console.Clear();

            // body type
            consoleHelper.BodyTypeOptions(role);
            string bodyType = "";
            if (role.Equals("Human"))
            {
                bodyType = CharacterParts.BodyTypeHuman[Validator.GetValidNumber("Choose your body type: ", 1, CharacterParts.BodyTypeHuman.Length) - 1];
            }
            else
            {
                bodyType = CharacterParts.BodyTypeZombie[Validator.GetValidNumber("Choose your body type: ", 1, CharacterParts.BodyTypeZombie.Length) - 1];
            }
            Console.Clear();

            //skin color 
            consoleHelper.SkinColorOptions(role);
            string skinColor = "";
            if (role.Equals("Human"))
            {
                skinColor = CharacterParts.SkinColorHuman[Validator.GetValidNumber("Choose your skin color: ", 1, CharacterParts.SkinColorHuman.Length) - 1];
            }
            else
            {
                skinColor = CharacterParts.SkinColorZombie[Validator.GetValidNumber("Choose your skin color: ", 1, CharacterParts.SkinColorZombie.Length) - 1];
            }
            Console.Clear();

            // posture
            consoleHelper.PostureOptions(role);
            string posture = "";
            if (role.Equals("Human"))
            {
                posture = CharacterParts.PostureTypeHuman[Validator.GetValidNumber("Choose your Posture Type: ", 1, CharacterParts.PostureTypeHuman.Length) - 1];
            }
            else
            {
                posture = CharacterParts.PostureTypeZombie[Validator.GetValidNumber("Choose your Posture Type: ", 1, CharacterParts.PostureTypeZombie.Length) - 1];
            }
            Console.Clear();

            // hats
            consoleHelper.HatTypeOptions(role);
            string hat = "";
            if (role.Equals("Human"))
            {
                hat = CharacterParts.HatTypeHuman[Validator.GetValidNumber("Choose your Hat Type: ", 1, CharacterParts.HatTypeHuman.Length) - 1];
            }
            else
            {
                hat = CharacterParts.HatTypeZombie[Validator.GetValidNumber("Choose your Hat Type: ", 1, CharacterParts.HatTypeZombie.Length) - 1];
            }
            Console.Clear();

            // shirt type
            consoleHelper.ShirtTypeOptions(role);
            string shirt = "";
            if (role.Equals("Human"))
            {
                shirt = CharacterParts.ShirtTypeHuman[Validator.GetValidNumber("Choose your Shirt Type: ", 1, CharacterParts.ShirtTypeHuman.Length) - 1];
            }
            else
            {
                shirt = CharacterParts.ShirtTypeZombie[Validator.GetValidNumber("Choose your Shirt Type: ", 1, CharacterParts.ShirtTypeZombie.Length) - 1];
            }
            Console.Clear();

            // jacket
            consoleHelper.JacketTypeOptions(role);
            string jacket = "";
            if (role.Equals("Human"))
            {
                jacket = CharacterParts.JacketTypeHuman[Validator.GetValidNumber("Choose your Jacket Type: ", 1, CharacterParts.JacketTypeHuman.Length) - 1];
            }
            else
            {
                jacket = CharacterParts.JacketTypeZombie[Validator.GetValidNumber("Choose your Jacket Type: ", 1, CharacterParts.JacketTypeZombie.Length) - 1];
            }
            Console.Clear();

            // pants type
            consoleHelper.PantsTypeOptions(role);
            string pantsType = "";
            if (role.Equals("Human"))
            {
                pantsType = CharacterParts.PantsTypeHuman[
                    Validator.GetValidNumber("Choose your pants type: ", 1, CharacterParts.PantsTypeHuman.Length) - 1];
            }
            else
            {
                pantsType = CharacterParts.PantsTypeZombie[
                    Validator.GetValidNumber("Choose your pants type: ", 1, CharacterParts.PantsTypeZombie.Length) - 1];
            }
            Console.Clear();

            //gloves
            consoleHelper.GlovesTypeOptions(role);
            string gloves = "";
            if (role.Equals("Human"))
            {
                gloves = CharacterParts.GlovesTypeHuman[
                    Validator.GetValidNumber("Choose your Gloves type: ", 1, CharacterParts.GlovesTypeHuman.Length) - 1];
            }
            else
            {
                pantsType = CharacterParts.GlovesTypeZombie[
                    Validator.GetValidNumber("Choose your Gloves type: ", 1, CharacterParts.GlovesTypeZombie.Length) - 1];
            }
            Console.Clear();

            //boots 
            consoleHelper.BootsTypeOptions(role);
            string boots = "";
            if (role.Equals("Human"))
            {
                boots = CharacterParts.JacketTypeHuman[Validator.GetValidNumber("Choose your Boots Type: ", 1, CharacterParts.BootsTypeHuman.Length) - 1];
            }
            else
            {
                boots = CharacterParts.JacketTypeZombie[Validator.GetValidNumber("Choose your Boots Type: ", 1, CharacterParts.BootsTypeZombie.Length) - 1];
            }
            Console.Clear();

            // armor
            consoleHelper.ArmorTypeOptions(role);
            string armor = "";
            if (role.Equals("Human"))
            {
                armor = CharacterParts.ArmorTypeHuman[Validator.GetValidNumber("Choose your Boots Type: ", 1, CharacterParts.ArmorTypeHuman.Length) - 1];
            }
            else
            {
                armor = CharacterParts.ArmorTypeZombie[Validator.GetValidNumber("Choose your Boots Type: ", 1, CharacterParts.ArmorTypeZombie.Length) - 1];
            }
            Console.Clear();

            // tattoos
            consoleHelper.TattoosOptions();
            string tattoo = CharacterParts.EyeTypes[Validator.GetValidNumber("Choose your tattoos types: ", 1, CharacterParts.TattooTypes.Length) - 1];
            Console.Clear();

            // weapon type
            consoleHelper.WeaponTypeOptions(role);
            string weaponType = "";
            if (role.Equals("Human"))
            {
                weaponType = CharacterParts.WeaponTypeHuman[
                    Validator.GetValidNumber("Choose your weapon type: ", 1, CharacterParts.WeaponTypeHuman.Length) - 1];
            }
            else
            {
                weaponType = CharacterParts.WeaponTypeZombie[
                    Validator.GetValidNumber("Choose your weapon type: ", 1, CharacterParts.WeaponTypeZombie.Length) - 1];
            }
            Console.Clear();

            // stealth perks [Validator.GetValidBoolean() gagamitin dito]
            consoleHelper.StealthOptions(role);
            bool isStealthy = Validator.GetValidBoolean("Do you want to have stealth perks? (yes/no): ");
            Console.Clear();

            // create character object
            // NOTE: Some attributes are set to "Sample" as placeholders and MUST be replaced
            //       with actual user inputs or logic as needed.
            Appearance appearance = new Appearance(eyeType, eyeColor, eyebrowColor, noseType, mouthType, hairStyle, facialHair, facialHairColor, scarsType, bodyType, skinColor, posture);
            Apparel apparel = new Apparel(hat, shirt, jacket, pantsType, gloves, boots);
            Equipment equipment = new Equipment(armor, tattoo, weapon: weaponType);

            return new Character(role, name: username, age, appearance, apparel, equipment, isStealthy);
        }

        private string AskChoice(string prompt, string[] options, Action? showOptions = null)
        {
            showOptions?.Invoke();
            int choice = Validator.GetValidNumber(prompt, 1, options.Length);
            return options[choice - 1];
        }
    }
}
