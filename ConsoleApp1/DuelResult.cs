using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DuelResult
    {
        public int DuelID { get; set; }
        public List<Wizard> Contestants { get; set; }
        public Wizard Winner { get; set; }
        public Wizard Loser { get; set; }
        public List<string> TurnLog { get; set; }

        public DuelResult(int DuelId, Wizard wizard1, Wizard wizard2)
        {
            this.DuelID = DuelId;
            Contestants = new List<Wizard> { wizard1, wizard2 };
            TurnLog = new List<string>();
        }
    }
}
