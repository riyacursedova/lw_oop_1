using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started, running Magic Duel Club\n");

            Spell stupify = new Spell("Ступефай", 15, Effect.Stunning);
            Spell expelliarmus = new Spell("Экспеллиармус", 20, Effect.Disarming);
            Spell petrificus = new Spell("Петрификус Тоталус", 25, Effect.Stunning);
            Spell crucio = new Spell("Круцио", 30, Effect.Damage);

            Wizard harry = new Wizard("Гарри Поттер", "Гриффиндор");
            Wizard draco = new Wizard("Драко Малфой", "Слизерин");
            Wizard hermione = new Wizard("Гермиона Грейнджер", "Гриффиндор");

            harry.LearnSpell(stupify);
            harry.LearnSpell(expelliarmus);

            draco.LearnSpell(petrificus);
            draco.LearnSpell(crucio);

            hermione.LearnSpell(stupify);
            hermione.LearnSpell(expelliarmus);
            hermione.LearnSpell(petrificus);

            DuelingClub club = new DuelingClub();

            Console.WriteLine("\nDuel #1");
            club.HostDuel(harry, draco);

            Console.WriteLine("\nDuel #2");
            club.HostDuel(hermione, draco);

            Console.WriteLine("\nDuel #3");
            club.HostDuel(harry, hermione);

            Console.WriteLine("\n" + new string('=', 40));
            harry.GetDuelHistory();

            Console.WriteLine("\n" + new string('=', 40));
            draco.GetDuelHistory();

            Console.WriteLine("\n" + new string('=', 40));
            hermione.GetDuelHistory();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
