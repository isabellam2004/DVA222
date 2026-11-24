namespace RPG_system
{
    class Race
    {
        int strength;
        int agility;
        int intelligence;
        int maxHP;

        protected Race(int strength, int agility, int intelligence, int maxHP)
        {
            this.strength = strength;
            this.agility = agility;
            this.intelligence = intelligence;
            this.maxHP = maxHP;
        }

        public int[] GetAttributes()
        {
            return [strength, agility, intelligence, maxHP];
        }
    }

    class Fairy : Race
    {
        public Fairy() : base(2, 5, 9, 20) { }
    }

    class Orc : Race
    {
        public Orc() : base(10, 3, 2, 40) { }
    }

    class Elf : Race
    {
        public Elf() : base(4, 7, 6, 30) { }
    }
}
