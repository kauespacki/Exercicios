// Resolvendo Fatorial com recursividade

/*Console.Write("Entre com um valor: ");
var valor = int.Parse(Console.ReadLine());
Console.WriteLine($"O fatorial é {Fatorial(valor)}");

int Fatorial(int x) {
    // caso-base
    if (x <= 1)
    {
        return 1;
    }

    return x * Fatorial(x - 1);
}*/

// Resolvendo Fibonacci com recursividade
// 0 1 1 2 3 5 8 1 3 2 1

Console.Write("Entre com a posição: ");
var posicao = int.Parse(Console.ReadLine());
Console.WriteLine($"O fibonacci na posição {posicao} é {Fibonacci(posicao)}");

int Fibonacci(int x)
{
    // caso-base
    if (x == 0 || x == 1)
    {
        return x;
    }

    return Fibonacci(x - 1) + Fibonacci(x - 2);
}