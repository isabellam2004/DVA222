namespace RPG_system
{
    class Character
    {
        string name;
        Category category;
        Race race;
        int hp;
        double xp;
        int maxHP;
        double initXP;

        public Character(string name, Race race, Category category)
        {
            this.name = name;
            this.category = category;
            this.race = race;
            maxHP = GetMaxHP();
            initXP = GetInitXP();
            HP = maxHP;
            XP = initXP;
        }

        public int GetAttribute(int attribute) => race.GetAttributes()[attribute];
        public int GetMaxHP() => race.GetMaxHP();
        public double GetInitXP() => category.GetInitXP();

        public double OnAttack()   // could prob simplify
        {
            Console.WriteLine("{0} {1}", name, category.GetAtkMessage());
            double attack = category.AttackFormula(GetAttribute(0), GetAttribute(1), GetAttribute(2));

            return attack*Random.Shared.NextDouble()*(xp - 0);
        }

        public double OnDefense()
        {
            Console.WriteLine("{0} {1}", name, category.GetDefMessage());
            double defense = category.DefenceFormula(GetAttribute(0), GetAttribute(1), GetAttribute(2));

            return defense * Random.Shared.NextDouble() * (xp - 0);
        }

        public string ToString()
        {
            return $"Name: {name}, XP: {XP}, Health: {HP}";
        }
        public string GetName()
        {
            return name;
        }
        public string victoryMessage()
        {
            return race.getVictoryMessage();
        }
        public int HP
        {
            get 
            { 
                return hp;
            }
            set
            {
                hp = Math.Clamp(value, 0, maxHP);
            }
        }
        public double XP
        {
            get
            {
                return xp;
            }
            set 
            {
                xp=Math.Clamp(value, initXP, 10);    // XP level cannot be higher than 10
            }
        }
    }

}

