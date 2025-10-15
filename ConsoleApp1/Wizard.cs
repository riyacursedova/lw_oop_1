using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Wizard
    {
        public string Name { get; set; }
        public string House { get; set; }
        public int Health { get; set; }
        public List<Spell> KnownSpells { get; set; } = new List<Spell>();

        private List<DuelResult> duelHistory = new List<DuelResult>();

        public Wizard(string name, string house)
        {
            Name = name;
            House = house;
            Health = 100;
        }

        public void LearnSpell(Spell spell)
        {
            KnownSpells.Add(spell);
            Console.WriteLine($"{Name} has learned the spell {spell.Name}");
        }

        public Spell CastRandomSpell()
        {
            if (KnownSpells.Count == 0)
            {
                Console.WriteLine($"{Name} has no spells!");
                return null;
            }
            Random rand = new Random();
            int index = rand.Next(KnownSpells.Count);
            Spell spell = KnownSpells[index];
            Console.WriteLine($"{Name} casts the spell {spell.Name}!");
            return spell;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
            Console.WriteLine($"{Name} takes {damage} damage and now has {Health} health");
        }

        public void AddDuelToHistory(DuelResult duelRecord)
        {
            duelHistory.Add(duelRecord);
            Console.WriteLine($"Duel added to {Name}'s history");
        }

        public void GetDuelHistory()
        {
            Console.WriteLine($"{Name}'s Duel History:");
            if (duelHistory.Count == 0)
            {
                Console.WriteLine("No duels yet.");
                return;
            }

            foreach (var duel in duelHistory)
            {
                string result = (duel.Winner == this) ? "WIN" : "LOSE";
                string opponent = (duel.Winner == this) ? duel.Loser.Name : duel.Winner.Name;
                Console.WriteLine($"Duel #{duel.DuelID}: {result} against {opponent}");
            }
        }
    }
}