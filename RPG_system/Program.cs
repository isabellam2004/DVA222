namespace RPG_system
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> list = new List<Character>();

            Character c1 = new Character("Albert", new Fairy(), new Warrior());
            Character c2 = new Character("Stefan", new Human(), new Archer());
            Character c3 = new Character("Berit", new Orc(), new Mage());
            Character c4 = new Character("Gunilla", new Elf(), new Archer());
            Character c5 = new Character("Ola", new Fairy(), new Archer());

            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);
            list.Add(c5);

            Tournament t = new Tournament(list);

            t.startTournament();  
        }
    }
}