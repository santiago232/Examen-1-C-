using System;

class Calculadora
{
    public double Suma(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Resta(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiplicacion(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Division(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new ArgumentException("No se puede dividir por cero.");
        }
        return num1 / num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        // Pruebas de los métodos
        Console.WriteLine("Suma: " + calc.Suma(5, 3));
        Console.WriteLine("Resta: " + calc.Resta(5, 3));
        Console.WriteLine("Multiplicación: " + calc.Multiplicacion(5, 3));
        try
        {
            Console.WriteLine("División: " + calc.Division(5, 3));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
