namespace CalculadoraTempo;

public static class Data
{
    public static void Iniciar()
    {
        Console.Clear();
        Console.WriteLine("PRIMEIRA DATA:");
        var data1 = ReceberValoresECriarHorario();
        Console.Clear();
        Console.WriteLine("SEGUNDA DATA:");
        var data2 = ReceberValoresECriarHorario();
        Console.Clear();
        var dataOperacao = DataMenu.OpcoesOperacoes(data1, data2);
        Console.Clear();
        Console.WriteLine($"A operação entre {data1:d} e {data2:d} é igual a {dataOperacao.Days} dias.");
    }
    
    public static DateTime CriarData(int ano, int mes, int dia)
    {
        var data = new DateTime(ano, mes, dia);
        return data;
    }
    
    public static DateTime ReceberValoresECriarHorario()
    {
        Console.Write("\n");
        Console.Write("Ano: ");
        var ano = int.Parse(Console.ReadLine());
        Console.Write("Mes: ");
        var mes = int.Parse(Console.ReadLine());
        Console.Write("Dia: ");
        var dia = int.Parse(Console.ReadLine());
        var data = CriarData(ano, mes, dia);
        return data;
    }

    public static TimeSpan Subtrair(DateTime data1, DateTime data2)
    {
        return data1.Subtract(data2);
    }
}