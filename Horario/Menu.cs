using System.Collections;

namespace Horario;

public static class Menu
{
    public static void Iniciar()
    {
        Console.Clear();
        Console.WriteLine("Você quer ver o horário em qual lugar?");
        var lugar = Console.ReadLine().Trim();
        var listaId = AdicionarAlternativasNaLista(lugar);
        Console.Clear();
        MostrarAlternativasDaLista(listaId);
        Console.Write("\n");
        Console.WriteLine("Qual id você deseja escolher?");
        var idEscolhido = Console.ReadLine();
        var horaDesejada = ConverterHoraUtcParaHoraDoId(idEscolhido);
        Console.Clear();
        Console.WriteLine($"Agora são {horaDesejada:hh:mm:ss tt} em {idEscolhido}.");
    }

    public static ArrayList AdicionarAlternativasNaLista(string lugar)
    {
        var timezones = TimeZoneInfo.GetSystemTimeZones();
        var listaId = new ArrayList();
        foreach (var timezone in timezones)
        {
            var id = timezone.Id;
            if (id.Contains(lugar, StringComparison.OrdinalIgnoreCase))
            {
                listaId.Add(id);
            }
        }
        if (listaId.Count == 0)
        {
            Console.WriteLine("Lugar não encontrado!");
            Environment.Exit(0);
        }
        return listaId;
    }

    public static void MostrarAlternativasDaLista(ArrayList listaId)
    {
        foreach (var nome in listaId)
        {
            Console.WriteLine(nome);
        }
    }

    public static DateTime ConverterHoraUtcParaHoraDoId(string idEscolhido)
    {
        var timezones = TimeZoneInfo.GetSystemTimeZones();
        var existeId = false;
        foreach (var timezone in timezones)
        {
            if (timezone.Id.Contains(idEscolhido))
            {
                existeId = true;
                break;
            }
        }
        if (!existeId)
        {
            Console.Clear();
            Console.WriteLine("Id não encontrado!");
            Environment.Exit(0);
        }
        var horaUtc = DateTime.UtcNow;
        var timezonePeloId = TimeZoneInfo.FindSystemTimeZoneById(idEscolhido);
        return TimeZoneInfo.ConvertTimeFromUtc(horaUtc, timezonePeloId);
    }
}