namespace Calculadora;

class Program
{
    private static int op;
    private static float v1;
    private static float v2;
    
    static void Main(string[] args)
    {
        Menu();
    }
    
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Menu:");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Resto da divisão");
        Console.WriteLine("6 - Potenciação");
        Console.WriteLine("0 - Sair");
        op = int.Parse(Console.ReadLine());
        
        switch (op)
        {
            case 1: Somar(); break;
            case 2: Subtrair(); break;
            case 3: Multiplicar(); break;
            case 4: Dividir(); break;
            case 5: RestoDivisao(); break;
            case 6: Potenciacao(); break;
            case 0: return;
            default:
            {
                Console.WriteLine("Opção inválida. Pressione ENTER para continuar.");
                Console.ReadKey();
                Menu();
                return;
                // break;
            }
        }
        
        Console.WriteLine("Pressione ENTER para continuar:");
        Console.ReadKey();
        
        // Recursão. Ponto de parada: case 0 do switch.
        Menu();
    }
    static void ReceberValores()
    {
        Console.Write("Digite o primeiro valor: ");
        v1 = float.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        v2 = float.Parse(Console.ReadLine());
    }
    static void Somar()
    {
        ReceberValores();
        Console.WriteLine($"A soma entre {v1} e {v2} é igual a {v1 + v2}!");
    }
    static void Subtrair()
    {
        ReceberValores();
        Console.WriteLine($"A subtração entre {v1} e {v2} é igual a {v1 - v2}!");
    }
    static void Multiplicar()
    {
        ReceberValores();
        Console.WriteLine($"A multiplicação entre {v1} e {v2} é igual a {v1 * v2}!");
    }
    static void Dividir()
    {
        ReceberValores();
        Console.WriteLine($"A divisão entre {v1} e {v2} é igual a {v1 / v2}!");
    }
    static void RestoDivisao()
    {
        ReceberValores();
        Console.WriteLine($"O resto da divisão entre {v1} e {v2} é igual a {v1 % v2}!");
    }
    static void Potenciacao()
    {
        ReceberValores();
        Console.WriteLine($"A potenciação entre {v1} e {v2} é igual a {Math.Pow(v1, v2)}!");
    }
}
