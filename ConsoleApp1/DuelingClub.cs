using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DuelingClub
    {
        public int duelCounter = 0;

        public DuelResult HostDuel(Wizard wizard1, Wizard wizard2)
        {
            duelCounter++;
            wizard1.Health = 100;
            wizard2.Health = 100;
            Console.WriteLine($"Duel {duelCounter} starts between {wizard1.Name} and {wizard2.Name}");

            DuelResult duelResult = new DuelResult(duelCounter, wizard1, wizard2);

            int turnNumber = 1;
            while (wizard1.Health > 0 && wizard2.Health > 0)
            {
                Console.WriteLine($"Turn {turnNumber}");

                Spell spell1 = wizard1.CastRandomSpell();
                if (spell1 != null)
                {
                    wizard2.TakeDamage(spell1.Damage);
                    string LogEntry = $"{wizard1.Name} casts {spell1.Name} dealing {spell1.Damage} damage to {wizard2.Name}";
                    duelResult.TurnLog.Add(LogEntry);
                }
                if (wizard2.Health <= 0) break;

                Spell spell2 = wizard2.CastRandomSpell();
                if (spell2 != null)
                {
                    wizard1.TakeDamage(spell2.Damage);
                    string LogEntry = $"{wizard2.Name} casts {spell2.Name} dealing {spell2.Damage} damage to {wizard1.Name}";
                    duelResult.TurnLog.Add(LogEntry);
                }

                turnNumber++;
            }

            if (wizard1.Health > 0)
            {
                duelResult.Winner = wizard1;
                duelResult.Loser = wizard2;
                Console.WriteLine($"{wizard1.Name} wins the duel!");
            }
            else
            {
                duelResult.Winner = wizard2;
                duelResult.Loser = wizard1;
                Console.WriteLine($"{wizard2.Name} wins the duel!");
            }

            wizard1.AddDuelToHistory(duelResult);
            wizard2.AddDuelToHistory(duelResult);

            return duelResult;
        }
    }
}