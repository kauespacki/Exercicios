namespace AdivinheONumero;

class Program
{
    static void Main(string[] args)
    {        
        IniciarJogo();
    }

    static void IniciarJogo()
    {
        Console.Clear();
        Console.WriteLine("ADIVINHE O NÚMERO ENTRE 1 A 100");
        Console.WriteLine("Pressione qualquer tecla para iniciar o jogo.");
        Console.ReadKey();
        int numeroSorteado = GerarNumero();
        int quantidadePalpites = 0;
        Jogo(numeroSorteado, quantidadePalpites);
    }

    static void Jogo(int numeroSorteado, int quantidadePalpites)
    {
        int palpite = Palpite();
        quantidadePalpites++;
        bool verificarPalpite = VerificarPalpite(numeroSorteado, palpite);
        if (verificarPalpite)
        {
            Console.WriteLine($"Parabéns, você acertou com {quantidadePalpites} palpites! O número sorteado era {numeroSorteado}.");
            Console.Write("Você quer continuar a jogar? [S/N] ");
            char continuar = char.Parse(Console.ReadLine().Substring(0, 1).ToLower());
            if (continuar == 's')
            {
                IniciarJogo();
            }
            return;
        }
        Jogo(numeroSorteado, quantidadePalpites);
    }

    static int Palpite()
    {
        Console.Clear();
        Console.Write("Palpite: ");
        int palpite = int.Parse(Console.ReadLine());
        return palpite;
    }

    static bool VerificarPalpite(int numeroSorteado, int palpite)
    {
        if (numeroSorteado == palpite)
        {
            return true;
        }

        if (palpite > numeroSorteado)
        {
            Console.WriteLine($"Dica: o número sorteado é menor que {palpite}.");
        }
        else
        {
            Console.WriteLine($"Dica: o número sorteado é maior que {palpite}.");
        }
        
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
        Console.ReadKey();
        return false;
    }

    static int GerarNumero()
    {
        var random = new Random();
        return random.Next(1, 100);
    }
}
