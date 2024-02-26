namespace CadastroClientes;

class Program
{
    private const string PATH = "clientes.txt";
    
    static void Main(string[] args)
    {
        IniciarCadastro();
    }
    
    static void IniciarCadastro()
    {
        // cria o arquivo clientes.txt se ele não existe.
        if (!File.Exists(PATH))
            using (File.Create(PATH));
        Menu();
    }
    
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1 - Cadastrar cliente");
        Console.WriteLine("2 - Mostrar clientes cadastrados");
        Console.WriteLine("0 - Sair");
        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1: Cadastrar(); break;
            case 2: MostrarClientes(); break;
            case 0: return;
            default: Menu(); return;
        }
        Menu();
    }
    
    static void Cadastrar()
    {
        Console.Clear();
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());
        string cadastrarCliente = $"Id: {id}; Nome: {nome}; Idade: {idade}";
        using (var file = File.AppendText(PATH))
            file.WriteLine(cadastrarCliente);
        Console.WriteLine("Cliente cadastrado com sucesso!");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
        Console.ReadKey();
    }

    static void MostrarClientes()
    {
        Console.Clear();
        Console.WriteLine("Clientes cadastrados:");
        using (var file = new StreamReader(PATH))
        {
            string clientes = file.ReadToEnd();
            Console.WriteLine(clientes);
        }
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
        Console.ReadKey();
    }
}
