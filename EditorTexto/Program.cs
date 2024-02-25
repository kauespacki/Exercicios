namespace EditorTexto;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1 - Ler arquivo");
        Console.WriteLine("2 - Criar arquivo/Escrever");
        Console.WriteLine("0 - Sair");
        short opcao = short.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
            {
                Console.WriteLine("Qual o caminho do arquivo que você deseja ler?");
                string pathDoArquivo = Console.ReadLine();
                LerArquivo(pathDoArquivo); break;
            }
            case 2:
            {
                Console.WriteLine("Qual o caminho do arquivo que você deseja criar?");
                string pathDoArquivo = Console.ReadLine();
                Console.WriteLine("O que você deseja escrever nele?");
                string textoDoArquivo = Console.ReadLine();
                CriarArquivo(pathDoArquivo, textoDoArquivo); break;
            }
            case 0: return;
        }
        Menu();
    }

    static void LerArquivo(string pathDoArquivo)
    {
        if (File.Exists(pathDoArquivo) == false)
        {
            Console.WriteLine($"Não existe nenhum arquivo com o caminho \"{pathDoArquivo}\"");
            Thread.Sleep(2500);
            return;
        }
        Console.WriteLine("Arquivo encontrado! Lendo...");
        Thread.Sleep(2500);
        Console.WriteLine("---------------------------------");
        string texto = File.ReadAllText(pathDoArquivo);
        Console.WriteLine(texto);
        Thread.Sleep(5000);
    }

    static void CriarArquivo(string pathDoArquivo, string textoDoArquivo)
    {
        if (File.Exists(pathDoArquivo))
        {
            Console.WriteLine("Esse arquivo já existe! Sobrescrevendo...");
            Thread.Sleep(2500);
        }
        else
        {
            Console.WriteLine("Criando o arquivo...");
            Thread.Sleep(2500);
        }
        File.WriteAllText(pathDoArquivo, textoDoArquivo);
        Console.WriteLine($"Arquivo \"{pathDoArquivo}\" com o conteúdo \"{textoDoArquivo}\" foi criado!");
        Thread.Sleep(5000);
    }
}
