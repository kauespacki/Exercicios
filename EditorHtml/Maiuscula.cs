namespace EditorHtml;

public static class Maiuscula
{
    public static void Mostrar(string texto)
    {
        Console.Clear();
        Console.WriteLine("Todas as letras em maiúsculas:");
        Console.WriteLine(ConverterParaMaiuscula(texto));
    }

    public static string ConverterParaMaiuscula(string texto)
    {
        return texto.ToUpper();
    }
}