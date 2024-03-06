namespace EditorHtml;

public static class Minuscula
{
    public static void Mostrar(string texto)
    {
        Console.Clear();
        Console.WriteLine("Todas as letras em minúsculas:");
        Console.WriteLine(ConverterParaMinuscula(texto));

    }

    public static string ConverterParaMinuscula(string texto)
    {
        return texto.ToLower();
    }
}