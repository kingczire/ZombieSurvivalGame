using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ZombieSurvivalGame.Domain;
using ZombieSurvivalGame.Model;
using ZombieSurvivalGame.Utils;
using static ZombieSurvivalGame.Domain.CharacterParts;

namespace ZombieSurvivalGame.Services
{
    public class GameService
    {
        public void Start()
        {
            GetCharacterFeatures();

            // Create Character

            // Save Character
        }

        public void GetCharacterFeatures()
        {
            ConsoleHelper consoleHelper = new ConsoleHelper();
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            ConsoleHelper.CharacterRoleOptions();
            string role = CharacterParts.RoleType[Validator.GetValidNumber("Choose your role: ", 1, 2) - 1];

            ConsoleHelper.AgeOptions();
            int ageChoice = Validator.GetValidNumber("Enter your age: ", 1, 4);


            consoleHelper.EyeTypeOptions();
            string eyeType = CharacterParts.EyeTypes[Validator.GetValidNumber("Choose your eye type: ", 1, CharacterParts.EyeTypes.Length) - 1];

            consoleHelper.NoseTypeOptions();
            string noseType = CharacterParts.NoseTypes[Validator.GetValidNumber("Choose your nose type: ", 1, CharacterParts.NoseTypes.Length) - 1];

            consoleHelper.MouthTypeOptions();
            string mouthType = CharacterParts.MouthTypes[Validator.GetValidNumber("Choose your mouth type: ", 1, CharacterParts.MouthTypes.Length) - 1];

            // has hair part

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

            Console.WriteLine("Success");

            if (role.Equals("Human"))
            {
                Console.WriteLine("Human type");
            }
            else

            {
                Console.WriteLine("Not human.");
            }
        }
    }
}

