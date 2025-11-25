namespace ZombieSurvivalGame.Domain.Structures
{
    public readonly struct Equipment
    {
        public string Armor { get; init; }
        public string Tattoo { get; init; }
        public string Weapon { get; init; }

        public Equipment(string armor, string tattoo, string weapon)
        {
            Armor = armor;
            Tattoo = tattoo;
            Weapon = weapon;
        }
    }
}
