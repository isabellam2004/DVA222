namespace RPG_system
{
    class Race
    {
        string race;
        int strength;
        int agility;
        int intelligence;
        int maxHP;

        protected Race(int strength, int agility, int intelligence, int maxHP, string race)
        {
            this.race = race;
            this.strength = strength;
            this.agility = agility;
            this.intelligence = intelligence;
            this.maxHP = maxHP;
        }

        public int[] GetAttributes()
        {
            return [strength, agility, intelligence];
        }

        public int GetMaxHP()
        {
            return maxHP;
        }

        public virtual string GetRace()
        {
            return race;
        }

        public virtual string getVictoryMessage() => throw new NotImplementedException();
    }

    class Fairy : Race
    {
        string[] victoryMSGs;

        public Fairy() : base(2, 5, 9, 20, "Fairy")
        {
            victoryMSGs = ["The fairy swirls around in the sky!", "The fairy jumps around and giggles and clapps its hands!"];
        }

        public override string getVictoryMessage()
        {
            Random rnd = new Random();

            int msgIndex = rnd.Next(victoryMSGs.Length);

            return victoryMSGs[msgIndex];
        }
    }

    class Orc : Race
    {
        string[] victoryMSGs;

        public Orc() : base(10, 3, 2, 40, "Orc")
        {
            victoryMSGs = ["The orc flexes its muscles and lets out a powerful roar!", "The orc roars in victory!"];
        }

        public override string getVictoryMessage()
        {
            Random rnd = new Random();

            int msgIndex = rnd.Next(victoryMSGs.Length);

            return victoryMSGs[msgIndex];
        }
    }

    class Elf : Race
    {
        string[] victoryMSGs;
 
        public Elf() : base(4, 7, 6, 30, "Elf")
        {
            victoryMSGs = ["The elf flexes its bow, letting out a victory sound!", "The elf stands tall and lifts its bow above its head!"];
        }

        public override string getVictoryMessage()
        {
            Random rnd = new Random();

            int msgIndex = rnd.Next(victoryMSGs.Length);

            return victoryMSGs[msgIndex];
        }
    }
    class Human : Race
    {
        string[] victoryMSGs;

        public Human() : base(6, 5, 5, 35, "Human")
        {
            victoryMSGs = ["The human celebrates his victory with some cake.", "The human cannot take credit for his victory because of cultural norms."];
        }

        public override string getVictoryMessage()
        {
            Random rnd = new Random();

            int msgIndex = rnd.Next(victoryMSGs.Length);

            return victoryMSGs[msgIndex];
        }
    }
}
