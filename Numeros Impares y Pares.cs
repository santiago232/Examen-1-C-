using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de números que desea ingresar: ");
        int cantidadNumeros = int.Parse(Console.ReadLine());

        int[] numeros = new int[cantidadNumeros];
        int pares = 0, impares = 0, sumaPares = 0, sumaImpares = 0;

        for (int i = 0; i < cantidadNumeros; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                pares++;
                sumaPares += numeros[i];
            }
            else
            {
                impares++;
                sumaImpares += numeros[i];
            }
        }

        Console.WriteLine($"Cantidad de números pares: {pares}");
        Console.WriteLine($"Cantidad de números impares: {impares}");
        Console.WriteLine($"Suma de números pares: {sumaPares}");
        Console.WriteLine($"Suma de números impares: {sumaImpares}");
    }
}
