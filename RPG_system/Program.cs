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

            Console.WriteLine(c1.OnAttack());
            Console.WriteLine(c2.OnAttack());
            Console.WriteLine(c3.OnAttack());
            Console.WriteLine(c4.OnAttack());

            Console.WriteLine(c1.OnDefence());
            Console.WriteLine(c2.OnDefence());
            Console.WriteLine(c3.OnDefence());
            Console.WriteLine(c4.OnDefence());

            Console.WriteLine("Gunilla takes psychological damage from being a wretch");
            c4.HP = c4.HP - 1;
            Console.WriteLine(c4.ToString());

            Console.WriteLine("Gunilla takes a substantital amount of psychological damage from being a wretch and dies.");
            c4.HP = c4.HP - 100;
            Console.WriteLine(c4.ToString());

            Console.WriteLine("Berit takes pity on Gunilla and revives her.");
            c4.HP = c4.HP + 100;
            Console.WriteLine(c4.ToString());   
        }
    }
}