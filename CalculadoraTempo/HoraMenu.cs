namespace CalculadoraTempo;

public static class HoraMenu
{
    public static TimeSpan OpcoesOperacoes(TimeSpan horario1, TimeSpan horario2)
    {
        MostrarOpcoes();
        int opcao = int.Parse(Console.ReadLine().Trim());
        return ManipularOpcao(opcao, horario1, horario2);
    }
    
    public static void MostrarOpcoes()
    {
        Console.Clear();
        Console.WriteLine("Qual operação você deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("0 - Sair");
    }
    
    public static TimeSpan ManipularOpcao(int opcao, TimeSpan horario1, TimeSpan horario2)
    {
        switch (opcao)
        {
            case 1: return Hora.Somar(horario1, horario2);
            case 2: return Hora.Subtrair(horario1, horario2);
            case 0: Environment.Exit(0); break;
            default: OpcoesOperacoes(horario1, horario2); break;
        }

        return new TimeSpan();
    }
}
