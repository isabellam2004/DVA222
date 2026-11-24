namespace RPG_system
{
    class Category
    {
        double initXP;

        protected Category(double initXP)
        {
            this.initXP = initXP;
        }

        public virtual double AttackFormula(int s, int a, int i) => throw new NotImplementedException();

        public virtual double DefenceFormula(int s, int a, int i) => throw new NotImplementedException();
    }

    class Warrior : Category
    {
        public Warrior() : base(3.70) { }

        public override double AttackFormula(int s, int a, int i)
        {
            return 0.6 * s + 0.3 * a + 0.1 * i;
        }

        public override double DefenceFormula(int s, int a, int i)
        {
            return 0.3 * s + 0.3 * a + 0.2 * i;
        }
    }

    class Mage : Category
    {
        public Mage() : base(2.75) { }

        public override double AttackFormula(int s, int a, int i)
        {
            return 0.2 * s + 0.2 * a + 1.0 * i;
        }

        public override double DefenceFormula(int s, int a, int i)
        {
            return 0.1 * s + 0.4 * a + 0.8 * i;
        }
    }

    class Archer : Category
    {
        public Archer() : base(3.15) { }

        public override double AttackFormula(int s, int a, int i)
        {
            return 0.3 * s + 0.7 * a + 0.2 * i;
        }

        public override double DefenceFormula(int s, int a, int i)
        {
            return 0.2 * s + 0.7 * a + 0.4 * i;
        }
    }
}
