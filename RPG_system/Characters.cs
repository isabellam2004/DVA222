namespace RPG_system
{
    class Character
    {
        // The variables that a character have:
        string name;
        Category category;
        Race race;
        int hp;
        double xp;
        int maxHP;
        double initXP;

        public Character(string name, Race race, Category category)     // Constructor which takes the name, the race and the category of the character
        {
            this.name = name;
            this.category = category;
            this.race = race;
            maxHP = GetMaxHP();
            initXP = GetInitXP();
            HP = maxHP;
            XP = initXP;
        }

        // Defines the character methods with composition of the methods from Race and Category:
        public string GetRace() => race.GetRace();
        public string GetCategory() => category.GetCategory();
        public int GetAttribute(int attribute) => race.GetAttributes()[attribute];
        public int GetMaxHP() => race.GetMaxHP();
        public double GetInitXP() => category.GetInitXP();
        public string victoryMessage() => race.getVictoryMessage();

        public double OnAttack()
        {
            Console.WriteLine("{0} {1}", name, category.GetAtkMessage());
            double attack = category.AttackFormula(GetAttribute(0), GetAttribute(1), GetAttribute(2));

            return attack * Random.Shared.NextDouble() * xp;
        }

        public double OnDefence()
        {
            Console.WriteLine("{0} {1}", name, category.GetDefMessage());
            double defense = category.DefenceFormula(GetAttribute(0), GetAttribute(1), GetAttribute(2));

            return defense * Random.Shared.NextDouble() * (xp - 0);
        }

        // Returns a string with character info

        public string ToString()
        {
            return $"Name: {name}, Race: {GetRace()}, Type: {GetCategory()}, XP: {XP}, Health: {HP}";
        }

        public string GetName()
        {
            return name;
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

