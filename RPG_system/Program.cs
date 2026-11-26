namespace RPG_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c1 = new Character("Albert", new Fairy(), new Warrior());
            Character c2 = new Character("Stefan", new Elf(), new Warrior());

            Console.WriteLine(c1.ToString());
        }
    }
}