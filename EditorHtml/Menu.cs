namespace EditorHtml;

public static class Menu
{
    private const int QUANTIDADE_COLUNAS = 35;
    private const int QUANTIDADE_LINHAS = 15;
    private const string SIMBOLO_COLUNA = "-";
    private const string SIMBOLO_LINHA = "|";
    private const string SIMBOLO_CANTO = "+";
    
    public static void ExibirMenu()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        DesenharTela();
        EscreverOpcoes();
        int opcao = int.Parse(Console.ReadLine());
        ManipularOpcaoMenu(opcao);
        ExibirMenu();
    }

    public static void DesenharTela()
    {
        DesenharColuna(QUANTIDADE_COLUNAS, SIMBOLO_COLUNA);
        DesenharLinha(QUANTIDADE_LINHAS, SIMBOLO_LINHA);
        DesenharColuna(QUANTIDADE_COLUNAS, SIMBOLO_COLUNA);
    }

    public static void DesenharColuna(int quantidadeColunas, string simbolo)
    {
        Console.Write(SIMBOLO_CANTO);
        DesenharColunaDentro(QUANTIDADE_COLUNAS, SIMBOLO_COLUNA);
        Console.Write(SIMBOLO_CANTO);
        Console.Write("\n");
    }

    public static void DesenharColunaDentro(int quantidadeColunas, string simbolo)
    {
        for(int i = 0; i < quantidadeColunas; i++)
            Console.Write(simbolo);
    }

    public static void DesenharLinha(int quantidadeLinhas, string simbolo)
    {
        for (int i = 0; i < quantidadeLinhas; i++)
        {
            Console.Write(simbolo);
            DesenharColunaDentro(QUANTIDADE_COLUNAS, " ");
            Console.Write(simbolo);
            Console.Write("\n");
        }
    }

    public static void EscreverOpcoes()
    {
        Console.SetCursorPosition(13, 1);
        Console.WriteLine("Editor HTML");
        
        Console.SetCursorPosition(1, 2);
        DesenharColunaDentro(35, "-");
        
        Console.SetCursorPosition(1, 3);
        Console.WriteLine("Selecione uma opção abaixo:");
        
        Console.SetCursorPosition(1, 4);
        Console.Write("\n");
        
        Console.SetCursorPosition(1, 5);
        Console.WriteLine("1 - Novo arquivo");
        
        Console.SetCursorPosition(1, 6);
        Console.WriteLine("2 - Abrir");
        
        Console.SetCursorPosition(1, 7);
        Console.Write("\n");
        
        Console.SetCursorPosition(1, 8);
        Console.WriteLine("0 - Sair");
        
        Console.SetCursorPosition(1, 9);
        Console.Write("\n");
        
        Console.SetCursorPosition(1, 10);
        Console.Write("Opção: ");
    }

    public static void ManipularOpcaoMenu(int opcao)
    {
        switch (opcao)
        {
            case 1: Editor.Mostrar(); break;
            case 2: Visualizador.Mostrar(""); break;
            case 0:
            {
                Console.Clear();
                Environment.Exit(0);
                break;
            }
            default: ExibirMenu(); break;
        }
    }
}
