namespace ZombieSurvivalGame.Domain
{
    public abstract class CharacterBase
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Role { get; protected set; }
        public int Age { get; protected set; }

        protected CharacterBase(string role, string name, int age)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
        }

        public virtual void DisplayCharacterInfo()
        {
            Console.WriteLine($"{Role}: {Name} (Age: {Age})");
        }

        public abstract void MakeSound();
    }
}
