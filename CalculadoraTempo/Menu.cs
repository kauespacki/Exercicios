namespace CalculadoraTempo;

public static class Menu
{
    public static void Iniciar()
    {
        Console.Clear();
        MostrarOpcoes();
        int opcao = int.Parse(Console.ReadLine().Trim());
        ManipularOpcao(opcao);
    }

    public static void MostrarOpcoes()
    {
        Console.WriteLine("O que você deseja calcular?");
        Console.WriteLine("1 - Data");
        Console.WriteLine("2 - Hora");
        Console.WriteLine("0 - Sair");
    }

    public static void ManipularOpcao(int opcao)
    {
        switch (opcao)
        {
            case 1: Data.Iniciar(); break;
            case 2: Hora.Iniciar(); break;
            case 0: Environment.Exit(0); break;
            default: Iniciar(); break;
        }
    }
}