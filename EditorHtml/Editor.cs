using System.Text;

namespace EditorHtml;

public static class Editor
{
    public static void Mostrar()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO EDITOR");
        Iniciar();
    }

    // iniciar o que? nome ruim.
    public static void Iniciar()
    {
        var texto = new StringBuilder();
        do
        {
            texto.Append(Console.ReadLine());
            texto.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.End);
        
        Console.WriteLine("Você deseja salvar o arquivo? [S/N]");
        var salvar = Console.ReadLine().Trim().ToLower()[0];
        if (salvar == 'n')
        {
            Console.WriteLine("Arquivo não salvado.");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
            Console.ReadKey();
            return;
        }
        Console.WriteLine("Onde você deseja salvar?");
        var caminho = Console.ReadLine().Trim();
        using (var arquivo = new StreamWriter(caminho))
            arquivo.Write(texto);
        
        Console.WriteLine($"Arquivo {caminho} salvo com sucesso!");
        Console.WriteLine("Pressione qualquer tecla para visualizar o seu texto.");
        Console.ReadKey();
        Visualizador.Mostrar(texto.ToString());
    }
}
