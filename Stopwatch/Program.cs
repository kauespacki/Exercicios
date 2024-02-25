namespace Stopwatch;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Quer contar regressivamente até 1 começando de qual tempo?");
        Console.WriteLine("S - Segundo => 10s");
        Console.WriteLine("M - Minuto => 1m");
        Console.WriteLine("0 - Sair");
        string output = Console.ReadLine().ToLower();
        if (output == "0")
        {
            return;
        }
        int value = int.Parse(output.Substring(0, output.Length - 1));
        char type = char.Parse(output.Substring(output.Length - 1, 1));
        int multiplier = 1;
        if (type == 'm')
        {
            multiplier = 60;
        }
        Start(value * multiplier);
        Menu();
    }

    static void Start(int time)
    {
        for (int i = time; i >= 1; i--)
        {
            Console.Clear();
            Console.WriteLine(i);
            Thread.Sleep(500);
        }
        Console.Clear();
        Console.WriteLine("Contagem finalizada!");
        Thread.Sleep(2500);
    }
}
