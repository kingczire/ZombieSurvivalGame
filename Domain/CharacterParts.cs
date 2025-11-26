namespace ZombieSurvivalGame.Domain
{
    public class CharacterParts
    {
        // role
        public readonly static string[] RoleType =
        {
            "Human - A survivor trying to stay alive and avoid zombies.", "Zombie - A creature hunting humans to infect them."
        };

        // age
        public readonly static int[] Ages = { 15, 26, 41, 60 };
        public readonly static string[] AgeDescriptions = { "Fast and agile, making it easier to outrun zombies.", "Strong and balanced, good at both fighting and escaping.", "Experienced and calm, better at planning and spotting danger.", "Wise and cautious, gains bonuses for strategy and resource management." };

        // eye
        public readonly static string[] EyeTypes =
        {
            "Almond",
            "Round",
            "Hooded",
            "Monolid"
        };

        // Eye colors
        public readonly static string[] EyeColorTypeHuman =
        {
            "Brown",
            "Black",
            "Red",
            "Blue"
        };
        public readonly static string[] EyeColorTypeZombie =
        {
            "Red",
            "White",
            "Black"
        };

        // Eyebrow colors
        public readonly static string[] EyebrowColorTypeHuman =
        {
            "Black",
            "Blonde",
            "Red",
            "Gray"
         };
        public readonly static string[] EyebrowColorTypeZombie =
        {
            "White",
            "Patchy",
            "Black",
            "Brown"
         };

        // nose
        public readonly static string[] NoseTypes =
        {
            "Small",
            "Normal",
            "Flat",
            "Broken"
        };

        // mouth
        public readonly static string[] MouthTypes =
        {
            "Small",
            "Normal",
            "Wide",
            "Frown",
            "Smile"
        };

        // hairstyle
        public readonly static string[] HairStyleHuman =
        {
            "Straight",
            "Curly",
            "Messy",
            "Short",
            "Long"
        };
        public readonly static string[] HairStyleZombie =
        {
            "Thinning",
            "Patchy"
        };

        // Facial hair
        public readonly static string[] FacialHairTypeHuman =
        {
            "Clean",
            "Shaven",
            "Mustache",
            "Full Beard"
        };
        public readonly static string[] FacialHairTypeZombie =
        {
            "Scraggly Beard",
            "Patchy Mustache",
            "Mangled Goatee",
            "Thining Stubble"
        };

        // Facial hair colors
        public readonly static string[] FacialHairColorTypeHuman =
        {
            "Brown",
            "Black",
            "Blonde",
            "Red",
            "Gray"
        };
        public readonly static string[] FacialHairColorTypeZombie =
        {
            "Gray",
            "White",
            "Patchy",
            "Black",
            "Brown"
        };

        // Scars
        public readonly static string[] ScarsTypeHuman =
        {
            "Fresh",
            "Bite Marks",
            "Surgical",
            "Slash"
        };
        public readonly static string[] ScarsTypeZombie =
        {
            "BiteMarks",
            "Slash",
            "Rot-like wounds"
        };

        // body type
        public readonly static string[] BodyTypeHuman =
        {
            "Skinny",
            "Slim",
            "Normal",
            "Burly",
            "Bulk"
        };
        public readonly static string[] BodyTypeZombie =
        {

           "Decayed",
            "Bloated",
            "Hunched"
        };

        // skin color
        public readonly static string[] SkinColorHuman =
          {
            "Dark",
            "Light",
            "Brown",
            "Pale",
            "Tan"
        };
        public readonly static string[] SkinColorZombie =
        {
            "Gray",
            "Green",
            "Decayed",
            "Rotting"
        };

        // posture
        public readonly static string[] PostureTypeHuman =
        {
            "Upright",
            "Slouched",
            "Leaning Forward",
            "Hunched",
            "Defensive",
        };
        public readonly static string[] PostureTypeZombie =
        {
            "Slouched",
            "Leaning Forward",
            "Hunched",
            "Casual",
            "Alert",
        };

        //  Hats
        public readonly static string[] HatTypeHuman =
        {
            "Baseball Cap",
            "Military Helmet",
            "Gas Mask",
            "Helmet",
            "Tactical Hat"
        };
        public readonly static string[] HatTypeZombie =
        {
            "Torn Bennie",
            "Half-on hood",
            "Damaged Helmet"
        };

        // shirt
        public readonly static string[] ShirtTypeHuman =
        {
            "T-Shirt",
            "Hoodie",
            "Long Sleeve",
            "Ripped",
            "Military",
        };
        public readonly static string[] ShirtTypeZombie =
        {
            "Torn",
            "Dirty",
            "Blood Stained",
        };

        // Jackets
        public readonly static string[] JacketTypeHuman =
        {
            "Leather",
            "Denim",
            "Military",
            "Trench Coat"
        };
        public readonly static string[] JacketTypeZombie =
        {
            "Ripped",
            "Tom",
            "Dirty Bomber",
            "Old Hoodie"
        };

        // pants
        public readonly static string[] PantsTypeHuman =
        {
            "Jeans",
            "Cargo",
            "Shorts",
            "Tactical",
            "Ripped"
        };
        public readonly static string[] PantsTypeZombie =
        {
            "Dirty",
            "Torn",
            "Loose",
            "Decayed"
        };

        // Gloves
        public readonly static string[] GlovesTypeHuman =
        {
            "Mechanic Gloves",
            "Surgical Gloves",
            "Winter Gloves",
            "Tactical"
        };
        public readonly static string[] GlovesTypeZombie =
        {
            "Ripped",
            "Blood-soaked",
            "Toxic Waste"
        };

        // Boots
        public readonly static string[] BootsTypeHuman =
        {
            "Combat",
            "Hiking",
            "Sneakers",
            "Barefoot"
        };
        public readonly static string[] BootsTypeZombie =
        {
            "Barefoot",
            "Decayed",
            "Old work boots"
        };

        //  Armor 
        public readonly static string[] ArmorTypeHuman =
        {
            "Tactical Vest",
            "Military Plate Armor",
            "Tactical Vest",
            "Body Armor"
        };
        public readonly static string[] ArmorTypeZombie =
        {
            "Chain-Wrapped Torso",
            "Scrap Tire Armor",
            "Burnt Firefighter Jacket"
        };

        //  Tattoos
        public readonly static string[] TattooTypes =
        {
            "Tribal",
            "Religious Symbols",
            "Band Logo",
            "Portrait"
        };
        // weapon
        public readonly static string[] WeaponTypeHuman =
        {
            "Machete",
            "Axe",
            "Shotgun",
            "Handgun",
            "Baseball Bat"
        };
        public readonly static string[] WeaponTypeZombie =
        {
            "Bite",
            "Claws"
        };

        // is stealthy
        public readonly static string[] IsStealthy =
        {
            "Yes - Your character moves quietly and avoids zombies more easily.",
            "No - Your character fights harder and deals more damage in combat."
        };
    }
}
