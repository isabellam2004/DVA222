namespace RPG_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c1 = new Character("Albert", new Fairy(), new Warrior());
            Character c2 = new Character("Stefan", new Elf(), new Archer());
            Character c3 = new Character("Berit", new Orc(), new Mage());
            Character c4 = new Character("Gunilla", new Human(), new Wretch());

            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());
            Console.WriteLine(c4.ToString());
        }
    }
}