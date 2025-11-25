using ZombieSurvivalGame.Domain;
using ZombieSurvivalGame.Domain.Structures;

namespace ZombieSurvivalGame.Model
{
    public class Character : CharacterBase
    {
        // Struct properties (grouped data)
        public Appearance Appearance { get; private set; }
        public Apparel Apparel { get; private set; }
        public Equipment Equipment { get; private set; }

        // Additional property
        public bool IsStealthy { get; private set; }

        // Constructor with individual parameters
        public Character(
            string role,
            string name,
            int age,
            string eye,
            string eyeColor,
            string eyebrowColor,
            string nose,
            string mouth,
            string hairStyle,
            string facialHair,
            string facialHairColor,
            string scar,
            string body,
            string skin,
            string posture,
            string hat,
            string shirt,
            string jacket,
            string pants,
            string gloves,
            string boots,
            string armor,
            string tattoo,
            string weapon,
            bool isStealthy
        ) : base(role, name, age)
        {
            this.Appearance = new Appearance(eye, eyeColor, eyebrowColor, nose, mouth, hairStyle, facialHair, facialHairColor, scar, body, skin, posture);
            this.Apparel = new Apparel(hat, shirt, jacket, pants, gloves, boots);
            this.Equipment = new Equipment(armor, tattoo, weapon);
            this.IsStealthy = isStealthy;
        }

        // Constructor with struct grouping (overloaded)
        public Character(
            string role,
            string name,
            int age,
            Appearance appearance,
            Apparel apparel,
            Equipment equipment,
            bool isStealthy
        ) : base(role, name, age)
        {
            this.Appearance = appearance;
            this.Apparel = apparel;
            this.Equipment = equipment;
            this.IsStealthy = isStealthy;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound... but subclasses should override this.");
        }

        // Display method with visual design
        public override void DisplayCharacterInfo()
        {
            base.DisplayCharacterInfo();

            string ageDescription = "";
            int index = Array.IndexOf(CharacterParts.Ages, Age);
            if (index >= 0 && index < CharacterParts.AgeDescriptions.Length)
                ageDescription = CharacterParts.AgeDescriptions[index];

            Console.WriteLine("\n╔════════════════════════════════════════╗");
            Console.WriteLine("║          CHARACTER INFORMATION         ║");
            Console.WriteLine("╚════════════════════════════════════════╝\n");

            // Basic info
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Age: {Age} ({ageDescription})\n");

            // Appearance section
            Console.WriteLine("╔════════════╗");
            Console.WriteLine("║ APPEARANCE ║");
            Console.WriteLine("╚════════════╝");
            Console.WriteLine($"- Eyes: {Appearance.Eye} (Color: {Appearance.EyeColor}, Eyebrow Color: {Appearance.EyebrowColor})");
            Console.WriteLine($"- Nose: {Appearance.Nose}");
            Console.WriteLine($"- Mouth: {Appearance.Mouth}");
            Console.WriteLine($"- Hair Style: {Appearance.HairStyle}");
            Console.WriteLine($"- Facial Hair: {Appearance.FacialHair} (Color: {Appearance.FacialHairColor})");
            Console.WriteLine($"- Scar: {Appearance.Scar}");
            Console.WriteLine($"- Body: {Appearance.Body} (Skin: {Appearance.Skin}, Posture: {Appearance.Posture})\n");

            // Clothing section
            Console.WriteLine("╔═══════════╗");
            Console.WriteLine("║ CLOTHING  ║");
            Console.WriteLine("╚═══════════╝");
            Console.WriteLine($"- Hat: {Apparel.Hat}");
            Console.WriteLine($"- Shirt: {Apparel.Shirt}");
            Console.WriteLine($"- Jacket: {Apparel.Jacket}");
            Console.WriteLine($"- Pants: {Apparel.Pants}");
            Console.WriteLine($"- Gloves: {Apparel.Gloves}");
            Console.WriteLine($"- Boots: {Apparel.Boots}\n");

            // Equipment section
            Console.WriteLine("╔═════════════╗");
            Console.WriteLine("║ EQUIPMENT   ║");
            Console.WriteLine("╚═════════════╝");
            Console.WriteLine($"- Armor: {Equipment.Armor}");
            Console.WriteLine($"- Tattoo: {Equipment.Tattoo}");
            Console.WriteLine($"- Weapon: {Equipment.Weapon}");
            Console.WriteLine($"- Stealthy: {(IsStealthy ? "Yes" : "No")}\n");

            Console.WriteLine("══════════════════════════════════════════\n");
        }
    }
}
