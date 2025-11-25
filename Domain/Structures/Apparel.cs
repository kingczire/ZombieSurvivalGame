namespace ZombieSurvivalGame.Domain.Structures
{
    public readonly struct Apparel
    {
        public string Hat { get; init; }
        public string Shirt { get; init; }
        public string Jacket { get; init; }
        public string Pants { get; init; }
        public string Gloves { get; init; }
        public string Boots { get; init; }

        public Apparel(string hat, string shirt, string jacket, string pants, string gloves, string boots)
        {
            Hat = hat;
            Shirt = shirt;
            Jacket = jacket;
            Pants = pants;
            Gloves = gloves;
            Boots = boots;
        }
    }
}
