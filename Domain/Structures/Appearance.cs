namespace ZombieSurvivalGame.Domain.Structures
{
    public readonly struct Appearance
    {
        public string Eye { get; init; }
        public string EyeColor { get; init; }
        public string EyebrowColor { get; init; }
        public string Nose { get; init; }
        public string Mouth { get; init; }
        public string HairStyle { get; init; }
        public string FacialHair { get; init; }
        public string FacialHairColor { get; init; }
        public string Scar { get; init; }
        public string Body { get; init; }
        public string Skin { get; init; }
        public string Posture { get; init; }

        public Appearance(
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
            string posture)
        {
            Eye = eye;
            EyeColor = eyeColor;
            EyebrowColor = eyebrowColor;
            Nose = nose;
            Mouth = mouth;
            HairStyle = hairStyle;
            FacialHair = facialHair;
            FacialHairColor = facialHairColor;
            Scar = scar;
            Body = body;
            Skin = skin;
            Posture = posture;
        }
    }
}
