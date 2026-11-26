using System.Data;

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
            return [strength, agility, intelligence];
        }

        public int GetMaxHP()
        {
            return maxHP;
        }

        public virtual string getVictoryMessage() => throw new NotImplementedException();
    }

    class Fairy : Race
    {
        string[] victoryMSGs = ["The fairy swirls around in the sky!", "The fairy jumps around and giggles and clapps its hands!"];

        public Fairy() : base(2, 5, 9, 20) { }

        public override string getVictoryMessage()
        {
            Random rnd = new Random();

            int msgIndex = rnd.Next(victoryMSGs.Length);

            return victoryMSGs[msgIndex];
        }
    }

    class Orc : Race
    {
        string[] victoryMSGs = ["The orc flexes its muscles and lets out a powerful roar!", "The orc roars in victory!"];

        public Orc() : base(10, 3, 2, 40) { }

        public override string getVictoryMessage()
        {
            Random rnd = new Random();

            int msgIndex = rnd.Next(victoryMSGs.Length);

            return victoryMSGs[msgIndex];
        }
    }

    class Elf : Race
    {
        string[] victoryMSGs = ["The elf flexes its bow, letting out a victory sound!", "The elf stands tall and lifts its bow above its head!"];
 
        public Elf() : base(4, 7, 6, 30) { }

        public override string getVictoryMessage()
        {
            Random rnd = new Random();

            int msgIndex = rnd.Next(victoryMSGs.Length);

            return victoryMSGs[msgIndex];
        }
    }
    class Human : Race
    {
        string[] victoryMSGs = ["The human celebrates his victory with some cake.", "The human won but cannot take credit for the victory because of cultural norms."];

        public Human() : base(6, 5, 5, 35) { }
        public override string getVictoryMessage()
        {
            Random rnd = new Random();

            int msgIndex = rnd.Next(victoryMSGs.Length);

            return victoryMSGs[msgIndex];
        }
    }
}
