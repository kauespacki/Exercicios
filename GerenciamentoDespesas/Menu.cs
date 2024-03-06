namespace GerenciamentoDespesas;

public static class Menu
{
    public static void Exibir()
    {
        EscreverOpcoes();
        int opcao = int.Parse(Console.ReadLine());
        ManipularOpcoes(opcao);
        Exibir();
    }

    public static void EscreverOpcoes()
    {
        Console.Clear();
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1 - Adicionar despesa");
        Console.WriteLine("2 - Ver despesas");
        Console.WriteLine("0 - Sair");
    }

    public static void ManipularOpcoes(int opcao)
    {
        switch (opcao)
        {
            case 1: Despesa.ReceberDadosParaAdicionar(); break;
            case 2: Despesa.Ver(); break;
            case 0: Environment.Exit(0); break;
            default: Exibir(); break;
        }
    }
}
