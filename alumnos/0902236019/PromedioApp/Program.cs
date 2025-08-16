using System;

namespace PromedioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            Console.WriteLine("Ingrese 5 números enteros:");

            for (int i = 0; i < 5; i++)
            {
                bool esEntero = false;
                int valor;

                do
                {
                    Console.Write($"Número {i + 1}: ");
                    string entrada = Console.ReadLine();

                    if (int.TryParse(entrada, out valor))
                    {
                        numeros[i] = valor;
                        esEntero = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: Debe ingresar un número entero.");
                    }
                } while (!esEntero);
            }

            double promedio = CalcularPromedio(numeros);

            Console.WriteLine($"\nEl promedio de los números es: {promedio:F2}");
        }

        static double CalcularPromedio(int[] arreglo)
        {
            int suma = 0;
            foreach (int num in arreglo)
            {
                suma += num;
            }
            return (double)suma / arreglo.Length;
        }
    }
}
