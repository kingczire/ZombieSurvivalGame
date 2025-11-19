using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSurvivalGame.Domain
{
    public class CharacterParts
    {

        // sundan ang role type
        public readonly static string[] RoleType =
        {
            "Human", "Zombie"
        };

        public readonly static int[] Ages = { 15, 26, 41, 60 };

        public readonly static string[] EyeTypes =
        {
            "Almond",
            "Round",
            "Hooded",
            "Monolid"
        };

        public readonly static string[] NoseTypes =
        {
            "Small",
            "Normal",
            "Flat",
            "Broken"
        };

        public readonly static string[] MouthTypes =
        {
            "Small",
            "Normal",
            "Wide",
            "Frown",
            "Smile"
        };

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


        public enum PostureType
        {
            Upright,
            Slouched,
            LeaningForward,
            Hunched,
            Defensive,
            Casual,
            Alert
        }

        public enum ShirtType
        {
            TShirt,
            Hoodie,
            LongSleeve,
            Ripped,
            Military,

            // Zombie
            Torn,
            Dirty,
            BloodStained
        }

        public enum PantsType
        {
            Jeans,
            Cargo,
            Shorts,
            Tactical,
            Ripped,

            // Zombie
            Dirty,
            Torn,
            Loose,
            Decayed
        }

        public enum WeaponType
        {
            Machete,
            Axe,
            Shotgun,
            Handgun,
            BaseballBat,

            // Zombie
            Bite,
            Claws
        }
    }
}
