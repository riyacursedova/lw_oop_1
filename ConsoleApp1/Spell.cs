using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Effect
    {
        Disarming,
        Stunning,
        Damage
    }

    public class Spell
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public Effect Effect { get; set; }

        public Spell(string name, int damage, Effect effect)
        {
            Name = name;
            Damage = damage;
            Effect = effect;
        }
    }
}