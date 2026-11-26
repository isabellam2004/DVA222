namespace RPG_system
{
    class Character
    {
        string name;
        Category category;
        Race race;
        int[] attributes;
        double HP;
        double XP;

        public Character(string name, Race race, Category category)
        {
            this.name = name;
            this.category = category;
            this.race = race;
            attributes = race.GetAttributes();
            HP = race.GetMaxHP();
            XP = category.GetInitXP();
        }

        public double OnAttack()   // could prob simplify
        {
            double attack = category.AttackFormula(attributes[0], attributes[1], attributes[2]);

            return attack*Random.Shared.NextDouble()*(XP - 0);
        }

        public double OnDefense()
        {
            double defense = category.DefenceFormula(attributes[0], attributes[1], attributes[2]);

            return defense * Random.Shared.NextDouble() * (XP - 0);
        }

        public string ToString()
        {
            return $"Name: {name}, XP: {XP}, Health: {HP}";
        }
    }

}

