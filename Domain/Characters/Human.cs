using ZombieSurvivalGame.Domain.Structures;
using ZombieSurvivalGame.Model;

namespace ZombieSurvivalGame.Domain.Characters
{
    internal class Human : Character
    {
        public Human(string role, string name, int age, Appearance appearance, Apparel apparel, Equipment equipment, bool isStealthy) : base(role, name, age, appearance, apparel, equipment, isStealthy)
        {
        }
    }
}
