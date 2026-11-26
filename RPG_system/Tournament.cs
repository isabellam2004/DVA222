using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            while(participants.Count() > 1) 
            { 
                // Select two alive characters, let them fight until only one remains alive, repeats until only one alive character left
                // Print out victor before returning?
            }
            
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
                Console.WriteLine("Round {0}", i);
                damage = attacker.OnAttack() - defender.OnDefense();
                if (damage < 0)
                {
                    damage = 0;
                }
                defender.HP -= (int)Math.Round(damage);
                if (defender.HP == 0)                           // If a character dies it breaks the loop
                {
                    Console.WriteLine("{0} died after their fight with {1}", defender.GetName(), attacker.GetName());
                    participants.Remove(defender);

                    Console.WriteLine(attacker.victoryMessage());
                    attacker.XP += 0.5;
                    attacker.HP += (int)Math.Round((attackerInitHP - attacker.HP)*0.5);     // HP-restoration by 50% for the winner
                    return;
                }
                else
                {
                    (attacker, defender) = (defender, attacker);    // Swapping attacker/defender
                    (attackerInitHP, defenderInitHP) = (defenderInitHP, attackerInitHP);
                }

                
            }
            
            Console.WriteLine("The fight between {0} and {1} resulted in a draw", attacker.GetName(), defender.GetName());
            attacker.XP += 0.25;    // Smaller XP increase for both characters
            defender.XP += 0.25;
            attacker.HP += (int)Math.Round((attackerInitHP - attacker.HP) * 0.5);   // HP restoration for both characters by 50%
            defender.HP += (int)Math.Round((defenderInitHP - defender.HP) * 0.5);
            return;
        }

    }
}
