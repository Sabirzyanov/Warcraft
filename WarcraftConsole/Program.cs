using WarcraftCore;

namespace WarcraftConsole;

public static class Program
{
    public static void Main(string[] args)
    {
        ConsoleLogger logger = new ConsoleLogger();
        int tickrate = 1;
        
        Footman f1 = new Footman(100, "Axe", 10, 0, 10, 15, 5, 10, logger);
        Mage m1 = new Mage(100, "Maga", 10, 0, 15, 3, 2, 3, 2, 100, logger);
        Blacksmith b = new Blacksmith(logger);

        List<Unit> units = new List<Unit> { f1, m1 };

        while (!f1.IsDestroyed() && !m1.IsDestroyed())
        {
            if (tickrate % f1.GetAttackSpeed() == 0)
            {
                f1.Attack(m1);            
            }

            if (tickrate % m1.GetAttackSpeed() == 0)
            {
                m1.Attack(f1);   
            }
            ++tickrate;
        }

        string winnerName = f1.IsDestroyed() ? m1.GetName() : f1.GetName();
        Console.WriteLine($"Win {winnerName}");
    }
}

