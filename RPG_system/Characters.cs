using RPG_system;
using System.Xml.Linq;

namespace Characters
{
    public class Character
    {
        string Name;
        Category category;
        Race race;
        double HP;
        double XP;
        public Character(string name, Race race, Category category)
        {
            this Name = name;
            this.race = race;
            this.category = category;
            this.HP = race.maxHP;
            this.XP = category.initXP;
        }
        double OnAttack()   // could prob simplify
        {
            double attack = category.AttackFormula(race.strength, race.agility, race.intelligence);

            return attack*Random.Shared.NextDouble()*(XP - 0);
        }
        double OnDefense()
        {
            double defense = category.DefenceFormula(race.strength, race.agility, race.intelligence);

            return defense * Random.Shared.NextDouble() * (XP - 0);
        }
        string ToString()
        {
            return $"Name: {name}, XP: {XP}, Health: {health}";
        }
    }

}

