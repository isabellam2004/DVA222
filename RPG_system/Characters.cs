namespace RPG_system
{
    class Character
    {
        string name;
        Category category;
        Race race;
        int HP;
        double XP;

        public Character(string name, Race race, Category category)
        {
            this.name = name;
            this.category = category;
            this.race = race;
            HP = GetMaxHP();
            XP = GetInitXP();
        }

        public int GetAttribute(int attribute) => race.GetAttributes()[attribute];
        public int GetMaxHP() => race.GetMaxHP();
        public double GetInitXP() => category.GetInitXP();

        public double OnAttack()   // could prob simplify
        {
            double attack = category.AttackFormula(GetAttribute(0), GetAttribute(1), GetAttribute(2));

            return attack*Random.Shared.NextDouble()*(XP - 0);
        }

        public double OnDefense()
        {
            double defense = category.DefenceFormula(GetAttribute(0), GetAttribute(1), GetAttribute(2));

            return defense * Random.Shared.NextDouble() * (XP - 0);
        }

        public string ToString()
        {
            return $"Name: {name}, XP: {XP}, Health: {HP}";
        }
    }

}

