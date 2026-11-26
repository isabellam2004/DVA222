namespace RPG_system
{
    class Tournament
    {
        int rounds;
        List<Character> participants;

        public Tournament(int rounds, List<Character> participants)     // Send amount of rounds each fight will be and the participants
        {
            this.rounds = rounds;
            this.participants = participants;
        }
        public void startTournament()
        {
            Random rnd = new Random();
            int idx1;
            int idx2;

            while(participants.Count() > 1)     // Tournament loop. Loops as long as there is more than one left in the participants list
            {
                idx1 = rnd.Next(participants.Count());  // Randomizes the index for the first fighter
                do
                {
                    idx2 = rnd.Next(participants.Count());  // Randomizes the index for the second fighter
                } while(idx1 == idx2);  // Only continues if the indices aren't the same

                Fight(participants[idx1], participants[idx2]);
            }

            Console.WriteLine("\nThe tournament is over, and the victor is {0}!", participants[0].GetName());
            return;
        }
        private void Fight(Character fighter1, Character fighter2)
        {
            Character attacker;
            Character defender;
            double damage;
            int attackerInitHP;     // Saving initial HP so for HP restoration
            int defenderInitHP;

            if(Random.Shared.Next(0,2) == 0)    // Selects which fighter gets to start attacking/defending before alternating between rounds.
            {
                attacker = fighter1;
                defender = fighter2;
                attackerInitHP = fighter1.HP;
                defenderInitHP = fighter2.HP;
            }
            else
            {
                attacker = fighter2;
                defender = fighter1;
                attackerInitHP = fighter2.HP;
                defenderInitHP = fighter1.HP;
            }
            
            for (int i = 1; i <= rounds; i++)
            {
                Console.WriteLine("\nRound {0}", i);
                damage = attacker.OnAttack() - defender.OnDefence();
                if (damage < 0)
                {
                    damage = 0;
                }
                defender.HP -= (int)Math.Round(damage);
                Console.WriteLine(defender.ToString());

                if (defender.HP == 0)                           // If a character dies it breaks the loop
                {
                    Console.WriteLine("\n{0} died after their fight with {1}.", defender.GetName(), attacker.GetName());
                    participants.Remove(defender);

                    Console.WriteLine("\n{0}", attacker.victoryMessage());
                    attacker.XP += 0.5;
                    attacker.HP += (int)Math.Round((attackerInitHP - attacker.HP) * 0.5);     // HP-restoration by 50% for the winner
                    return;
                }
                else
                {
                    (attacker, defender) = (defender, attacker);    // Swapping attacker/defender
                    (attackerInitHP, defenderInitHP) = (defenderInitHP, attackerInitHP);
                }
            }
            
            Console.WriteLine("\nThe fight between {0} and {1} resulted in a draw.", attacker.GetName(), defender.GetName());
            attacker.XP += 0.25;    // Smaller XP increase for both characters
            defender.XP += 0.25;
            attacker.HP += (int)Math.Round((attackerInitHP - attacker.HP) * 0.5);   // HP restoration for both characters by 50%
            defender.HP += (int)Math.Round((defenderInitHP - defender.HP) * 0.5);
            // Stat print for both after the draw:
            Console.WriteLine(attacker.ToString());
            Console.WriteLine(defender.ToString());
            return;
        }
    }
}
