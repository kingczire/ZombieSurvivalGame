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

                //Thread.Sleep(delay);
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
        public void StealthOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human"))
            {
                for (int i = 0; i < CharacterParts.IsStealthy.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.IsStealthy[i]}");
                }
            }
        }
    }
}


