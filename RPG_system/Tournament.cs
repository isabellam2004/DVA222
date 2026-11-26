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
        Character[] participants;
        string? tournamentWinner;
        string? fightWinner;

        public Tournament(int rounds, Character[] participants)     // Send amount of rounds each fight will be and the participants
        {
            this.rounds = rounds;
            this.participants = participants;
            this.tournamentWinner = null;
        }
        public string? startTournament()
        {
            while(tournamentWinner == null) 
            { 
                // Select two alive characters, let them fight until only one remains alive, repeats until only one alive character left
                
            }
            return tournamentWinner;
        }
        private string? Fight(Character fighter1, Character fighter2)
        {
            Character? attacker;
            Character? defender;
            double damage;

            if(Random.Shared.Next(0,1) == 0)    // Selects which fighter gets to start attacking/defending before alternating between rounds.
            {
                attacker = fighter1;
                defender = fighter2;
            }
            else
            {
                attacker = fighter2;
                defender = fighter1;
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
                (attacker, defender) = (defender, attacker);    // Swapping attacker/defender

                if (defender.HP == 0)
                    fightWinner = attacker;
            }

            
            return fightWinner;
        }

    }
}
