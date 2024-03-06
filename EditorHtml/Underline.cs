using System.Text;

namespace EditorHtml;

public static class Underline
{
    public static void Mostrar(string texto)
    {
        Console.Clear();
        Console.WriteLine("Texto separado por underline:");
        Console.WriteLine(TextoSeparadoUnderline(texto));
    }

    public static string TextoSeparadoUnderline(string texto)
    {
        return texto.Replace(' ', '_');
    }
}