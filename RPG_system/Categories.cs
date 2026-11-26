namespace RPG_system
{
    class Category
    {
        double initXP;

        protected Category(double initXP)
        {
            this.initXP = initXP;
        }

        public double GetInitXP()
        {
            return initXP;
        }

        public virtual double AttackFormula(int s, int a, int i) => throw new NotImplementedException();

        public virtual double DefenceFormula(int s, int a, int i) => throw new NotImplementedException();

        public virtual string GetAtkMessage() => throw new NotImplementedException();

        public virtual string GetDefMessage() => throw new NotImplementedException();
    }

    class Warrior : Category
    {
        string atkMSG = "swings a mighty sword!";
        string defMSG = "blocks with a shield!";

        public Warrior() : base(3.70) { }

        public override double AttackFormula(int s, int a, int i)
        {
            return 0.6 * s + 0.3 * a + 0.1 * i;
        }

        public override double DefenceFormula(int s, int a, int i)
        {
            return 0.3 * s + 0.3 * a + 0.2 * i;
        }

        public override string GetAtkMessage()
        {
            return atkMSG;
        }

        public override string GetDefMessage()
        {
            return defMSG;
        }
    }

    class Mage : Category
    {
        string atkMSG = "casts a firebal!";
        string defMSG = "creates a magical barrier!";

        public Mage() : base(2.75) { }

        public override double AttackFormula(int s, int a, int i)
        {
            return 0.2 * s + 0.2 * a + 1.0 * i;
        }

        public override double DefenceFormula(int s, int a, int i)
        {
            return 0.1 * s + 0.4 * a + 0.8 * i;
        }

        public override string GetAtkMessage()
        {
            return atkMSG;
        }

        public override string GetDefMessage()
        {
            return defMSG;
        }
    }

    class Archer : Category
    {
        string atkMSG = "shoots an arrow!";
        string defMSG = "dodges swiftly!";

        public Archer() : base(3.15) { }

        public override double AttackFormula(int s, int a, int i)
        {
            return 0.3 * s + 0.7 * a + 0.2 * i;
        }

        public override double DefenceFormula(int s, int a, int i)
        {
            return 0.2 * s + 0.7 * a + 0.4 * i;
        }

        public override string GetAtkMessage()
        {
            return atkMSG;
        }

        public override string GetDefMessage()
        {
            return defMSG;
        }
    }
    class Wretch : Category
    {
        string atkMSG = "whimpers while throwing a weak punch";
        string defMSG = "slips and fall, accidentally dodging";
        
        public Wretch() : base(1.50) { }
        public override double AttackFormula(int s, int a, int i)
        {
            return 0.2 * s + 0.2 * a + 0.2 * i;     // Might need som balancing
        }
        public override double DefenceFormula(int s, int a, int i)
        {
            return 0.2 * s + 0.2 * a + 0.2 * i;
        }
        public override string GetAtkMessage() 
        {
            return atkMSG;
        }
        public override String GetDefMessage()
        {
            return defMSG;
        }
    }
}
