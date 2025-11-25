namespace ZombieSurvivalGame.Domain
{
    public interface CharacterActions
    {
        public abstract void Attack();
        public abstract void Attack(string weapon);
    }
}
