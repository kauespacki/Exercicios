namespace CalculadoraTempo;

public static class Hora
{
    public static void Iniciar()
    {
        Console.Clear();
        Console.WriteLine("PRIMEIRO HORÁRIO:");
        var horario1 = ReceberValoresECriarHorario();
        Console.Clear();
        Console.WriteLine("SEGUNDO HORÁRIO:");
        var horario2 = ReceberValoresECriarHorario();
        Console.Clear();
        var horarioOperacao = HoraMenu.OpcoesOperacoes(horario1, horario2);
        Console.Clear();
        Console.WriteLine($"A operação entre {horario1} horas e {horario2} horas é igual a {horarioOperacao}!");
    }
    
    public static TimeSpan CriarHorario(int horas, int minutos, int segundos)
    {
        var horario = new TimeSpan(horas, minutos, segundos);
        return horario;
    }
    
    public static TimeSpan ReceberValoresECriarHorario()
    {
        Console.Write("\n");
        Console.Write("Horas: ");
        var horas = int.Parse(Console.ReadLine());
        Console.Write("Minutos: ");
        var minutos = int.Parse(Console.ReadLine());
        Console.Write("Segundos: ");
        var segundos = int.Parse(Console.ReadLine());
        var horario = CriarHorario(horas, minutos, segundos);
        return horario;
    }

    public static TimeSpan Somar(TimeSpan horario1, TimeSpan horario2)
    {
        return horario1.Add(horario2);
    }
    
    public static TimeSpan Subtrair(TimeSpan horario1, TimeSpan horario2)
    {
        return horario1.Subtract(horario2);
    }
}