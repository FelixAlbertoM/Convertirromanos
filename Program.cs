using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce un numero romano:");
        string numromano = Console.ReadLine().ToUpper();

        int resultado = Convertirromano(numromano);
        Console.WriteLine("El numero es: " + resultado);
    }

    static int Convertirromano(string romano)
    {
        int total = 0;

        for (int i = 0; i < romano.Length; i++)
        {
            int valoractual = valor(romano[i]);
            int valorsiguiente = 0;

            if (i + 1 < romano.Length)
            {
                valorsiguiente = valor(romano[i + 1]);
            }

            if (valoractual < valorsiguiente)
            {
                total -= valoractual;
            }
            else
            {
                total += valoractual;
            }
        }
        return total;
    }

    static int valor(char letra)
    {
        if (letra == 'I') return 1;
        if (letra == 'V') return 5;
        if (letra == 'X') return 10;
        if (letra == 'L') return 50;
        if (letra == 'C') return 100;
        if (letra == 'D') return 500;
        if (letra == 'M') return 1000;
        return 0;
    }
}