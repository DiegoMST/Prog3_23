﻿Console.WriteLine("Cálculio Fatorial Recursivo");
Console.WriteLine("***************************");
Console.WriteLine();

Console.WriteLine("Digite um número:");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Fatorial de {numero} é {Factorial(numero)}");
Console.WriteLine($"Fibonacci de {numero} e {Fibonacci(numero)}");

static int Factorial(int number)
{
    //Caso base 1 
    if(number < 0)
    {
        throw new ArgumentException(
            message: $"A função fatorial não suporta números negativos. Input {number}",
            paramName: nameof(number)
        );
    }else if(number == 0) //Caso base 2
    {
        return 1;
    }
    else // Caso recursivo
    {
        return number * Factorial(number -1);
    }
}



static long Fibonacci(int n)
{
    if( n <= 2L) 
        return 1L;
    
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

static void multiplicarwhile(int n)
{
    int fator = 1;
    while(fator > 10)
    {
        Console.WriteLine($"{n} x {fator} = {n * fator}");
        fator++;
    }
}