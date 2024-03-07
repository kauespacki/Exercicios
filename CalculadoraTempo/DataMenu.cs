namespace CalculadoraTempo;

public static class DataMenu
{
    public static TimeSpan OpcoesOperacoes(DateTime data1, DateTime data2)
    {
        MostrarOpcoes();
        int opcao = int.Parse(Console.ReadLine().Trim());
        return ManipularOpcao(opcao, data1, data2);
    }
    
    public static void MostrarOpcoes()
    {
        Console.Clear();
        Console.WriteLine("Qual operação você deseja fazer?");
        Console.WriteLine("1 - Subtração");
        Console.WriteLine("0 - Sair");
    }
    
    public static TimeSpan ManipularOpcao(int opcao, DateTime data1, DateTime data2)
    {
        switch (opcao)
        {
            case 1: return Data.Subtrair(data1, data2);
            case 0: Environment.Exit(0); break;
            default: OpcoesOperacoes(data1, data2); break;
        }

        return new TimeSpan();
    }
}