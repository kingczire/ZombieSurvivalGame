using ZombieSurvivalGame.Domain;

namespace ZombieSurvivalGame.Utils
{
    public class ConsoleHelper
    {
        public ConsoleHelper()
        {
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


        public void MenuOptions()
        {
            Console.Clear();
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. Campaign Mode");
            Console.WriteLine("4. Credits");
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

        public void HasHairOptions()
        {
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
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

        public void PostureOptions(string role)
        {
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

        public void ShirtTypeOptions(string role)
        {
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

        public void PantsTypeOptions(string role)
        {
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

        public void WeaponTypeOptions(string role)
        {
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

    }
}


