using System.Text;
using System.Text.RegularExpressions;

namespace EditorHtml;

public static class Visualizador
{
    public static void Mostrar(string texto)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        texto = ReceberArquivo();
        ExibirMenu(texto);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
        Console.ReadKey();
    }

    public static string ReceberArquivo()
    {
        Console.WriteLine("Qual arquivo você deseja abrir?");
        var caminho = Console.ReadLine();
        var texto = "";
        using (var arquivo = new StreamReader(caminho))
        {
            texto = arquivo.ReadToEnd();
        }
        return texto;
    }
    
    // OpcoesLeitura
    public static void ExibirMenu(string texto)
    {
        EscreverOpcoes();
        int opcao = int.Parse(Console.ReadLine());
        var novoTexto = Trocar(texto);
        ManipularOpcoes(opcao, novoTexto);
    }

    public static void EscreverOpcoes()
    {
        Console.Clear();
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1 - Ler o texto com todas as letras sendo em maiúsculas");
        Console.WriteLine("2 - Ler o texto com todas as letras sendo em minúsculas");
        Console.WriteLine("3 - Trocar os espaços por um underline");
        Console.WriteLine("0 - Sair");
    }

    public static void ManipularOpcoes(int opcao, string texto)
    {
        switch (opcao)
        {
            case 1: Maiuscula.Mostrar(texto); break;
            case 2: Minuscula.Mostrar(texto); break;
            case 3: Underline.Mostrar(texto); break;
            case 0: Environment.Exit(0); break;
            default: ExibirMenu(texto); break;
        }
    }

    public static string Trocar(string texto)
    {
        // esse regex verifica se uma palavra está entre <strong> e </strong>
        var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
        var words = texto.Split(" ");
        var novoTexto = new StringBuilder();
        foreach (var word in words)
        {
            if (strong.IsMatch(word))
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                novoTexto.Append(word.Substring(
                        word.IndexOf('>') + 1,
                        word.LastIndexOf('<') - 1 - word.IndexOf('>')
                    )
                );
            }
            else
            {
                novoTexto.Append(word);
            }
            Console.ForegroundColor = ConsoleColor.Black;
            novoTexto.Append(" ");
        }
        Console.Write("\n");
        return novoTexto.ToString();
    }
}
