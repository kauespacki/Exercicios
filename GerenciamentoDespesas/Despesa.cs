using System.Text;

namespace GerenciamentoDespesas;

public static class Despesa
{
    public static string ReceberCategoria()
    {
        Console.Clear();
        Console.Write("Categoria: ");
        return Console.ReadLine().Trim().ToLower();
    }
    
    public static void ReceberDadosParaAdicionar()
    {
        string categoria = ReceberCategoria();
        string caminho = $"{categoria}.txt";
        
        Console.Write("Nome da despesa: ");
        string nome = Console.ReadLine();
        Console.Write("Valor: ");
        double valor = double.Parse(Console.ReadLine());
        Console.Write("Data: ");
        string data = Console.ReadLine();
        
        Adicionar(caminho, categoria, nome, valor, data);
    }
    
    public static void Adicionar(string caminho, string categoria, string nome, double valor, string data)
    {
        var despesa = new StringBuilder();
        despesa.Append($"Nome: {nome}; Valor: {valor}; Data: {data}");
        using (var arquivo = File.AppendText(caminho))
        {
            arquivo.Write(despesa);
            arquivo.Write("\n");
        }
        Console.WriteLine("Despesa adicionada com sucesso!");
        Console.WriteLine("Pressione qualquer tecla para voltar para o menu inicial.");
        Console.ReadKey();
    }
    
    public static void Ver()
    {
        Console.Clear();
        string categoria = ReceberCategoria();
        string caminho = $"{categoria}.txt";
        
        if (!CategoriaExiste(categoria, caminho))
            return;
            
        Console.Clear();
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine("--------------------------------");

        using (var arquivo = new StreamReader(caminho)) 
            Console.WriteLine(arquivo.ReadToEnd());
        
        Console.WriteLine("Pressione qualquer tecla para voltar para o menu inicial.");
        Console.ReadKey();
    }

    public static bool CategoriaExiste(string categoria, string caminho)
    {
        if (!File.Exists(caminho))
        {
            Console.WriteLine($"Categoria '{categoria}' não existe.");
            Console.WriteLine("Pressione qualquer tecla para voltar para o menu inicial.");
            Console.ReadKey();
            return false;
        }

        return true;
    }
}
