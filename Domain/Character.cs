using static ZombieSurvivalGame.Domain.CharacterParts;

namespace ZombieSurvivalGame.Model
{
    public class Character
    {
        // Properties
        public int Id { get; set; }  
        public string Name { get; set; }
        public string Role { get; private set; }
        public int Age { get; private set; }

        public string Eye { get; private set; }
        public string Nose { get; private set; }
        public string Mouth { get; private set; }

        // make the types as string
        public bool HasHair { get; private set; }
        public string HairStyle { get; private set; }

        public string Body { get; private set; }
        public string Skin { get; private set; }

        public PostureType Posture { get; private set; }

        public ShirtType Shirt { get; private set; }
        public PantsType Pants { get; private set; }

        public WeaponType Weapon { get; private set; }

        // Constructor
        public Character(
            string role,
            string name,
            int age,
            string eye,
            string nose,
            string mouth,
            bool hasHair,
            string hairStyle,
            string body,
            string skin,
            PostureType posture,
            ShirtType shirt,
            PantsType pants,
            WeaponType weapon)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Eye = eye;
            this.Nose = nose;
            this.Mouth = mouth;
            this.HasHair = hasHair;
            this.HairStyle = hairStyle;
            this.Body = body;
            this.Skin = skin;
            this.Posture = posture;
            this.Shirt = shirt;
            this.Pants = pants;
            this.Weapon = weapon;
        }

        public Character() { }
    }
}
