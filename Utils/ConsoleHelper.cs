using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ZombieSurvivalGame.Domain;
using ZombieSurvivalGame.Model;

namespace ZombieSurvivalGame.Utils
{
    public class ConsoleHelper
    {
        // Removed dependence on an internal Character instance to avoid null refs.

        public ConsoleHelper()
        {
        }

        public static void AgeOptions()
        {
            for (int i = 0; i < CharacterParts.Ages.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.Ages[i]}");
            }
        }

        public static void CharacterRoleOptions()
        {
            for (int i = 0; i < CharacterParts.RoleType.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.RoleType[i]}");
            }
        }

        public void EyeTypeOptions()
        {
            for (int i = 0; i < CharacterParts.EyeTypes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.EyeTypes[i]}");
            }
        }

        public void NoseTypeOptions()
        {
            for (int i = 0; i < CharacterParts.NoseTypes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.NoseTypes[i]}");
            }
        }

        public void MouthTypeOptions()
        {
            for (int i = 0; i < CharacterParts.MouthTypes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.MouthTypes[i]}");
            }
        }

        // Use role parameter instead of reading a possibly-null character
        public void HairStyleOptions(string role)
        {
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

        public void BodyTypeOptions(string role)
        {
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

        public void SkinColorOptions(string role)
        {
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
    }
}


