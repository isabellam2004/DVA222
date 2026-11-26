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
        double maxXP;

        public Character(string name, Race race, Category category)
        {
            this.name = name;
            this.category = category;
            this.race = race;
            maxHP = GetMaxHP();
            maxXP = GetInitXP();
            HP = maxHP;
            XP = maxXP;
        }

        public string GetRace() => race.GetRace();
        public string GetCategory() => category.GetCategory();
        public int GetAttribute(int attribute) => race.GetAttributes()[attribute];
        public int GetMaxHP() => race.GetMaxHP();
        public double GetInitXP() => category.GetInitXP();
        public double OnAttack() => Random.Shared.NextDouble() * XP * category.AttackFormula(GetAttribute(0), GetAttribute(1), GetAttribute(2));
        public double OnDefence() => Random.Shared.NextDouble() * XP * category.DefenceFormula(GetAttribute(0), GetAttribute(1), GetAttribute(2));

        public string ToString()
        {
            return $"Name: {name}, Race: {GetRace()}, Type: {GetCategory()} XP: {XP}, Health: {HP}";
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
                xp=Math.Clamp(value, 0,maxXP);
            }
        }
    }

}

