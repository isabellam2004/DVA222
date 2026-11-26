namespace RPG_system
{
    class Category
    {
        // The variables that a category have:
        string category;
        double initXP;

        protected Category(double initXP, string category)  // Constructor which takes the initial XP and the category type
        {
            this.initXP = initXP;
            this.category = category;
        }

        // Returns the type
        public string GetCategory()
        {
            return category;
        }

        // Returns the type specific initial XP
        public double GetInitXP()
        {
            return initXP;
        }

        // Methods which every category type should contain:

        // Calculates attack points with a type specific formula, and rreturns it
        public virtual double AttackFormula(int s, int a, int i) => throw new NotImplementedException();

        // Calculates defence points with a type specific formula, and returns it
        public virtual double DefenceFormula(int s, int a, int i) => throw new NotImplementedException();

        // Returns a type specific attack message
        public virtual string GetAtkMessage() => throw new NotImplementedException();

        // Returns a type specific defence message
        public virtual string GetDefMessage() => throw new NotImplementedException();
    }

    class Warrior : Category
    {
        string atkMSG = "swings a mighty sword!";   // Attack message
        string defMSG = "blocks with a shield!";    // Defence message

        public Warrior() : base(3.70, "Warrior") { }    // Sends the type specific initial XP (3.70) and the type to the parent constructor

        public override double AttackFormula(int s, int a, int i)
        {
            return 0.6 * s + 0.3 * a + 0.1 * i;     // Attack formula
        }

        public override double DefenceFormula(int s, int a, int i)
        {
            return 0.3 * s + 0.3 * a + 0.2 * i;     // Defence formula
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

        public Mage() : base(2.75, "Mage") { }

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

        public Archer() : base(3.15, "Archer") { }

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
        
        public Wretch() : base(1.50, "Wretch") { }
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
