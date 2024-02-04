using Tarea_Array;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el tamaño del array:");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        Console.WriteLine($"Ingrese {size} números:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        ArrayManipulator manipulator = new ArrayManipulator(numbers);

        int[] primeNumbersWithoutDuplicates = manipulator.GetPrimeNumbersWithoutDuplicates();
        int[] leastRepeatedNumbers = manipulator.GetLeastRepeatedNumbers();
        int[] mostRepeatedNumbers = manipulator.GetMostRepeatedNumbers();

        // Ordenar los resultados antes de mostrarlos
        Array.Sort(primeNumbersWithoutDuplicates);
        Array.Sort(leastRepeatedNumbers);
        Array.Sort(mostRepeatedNumbers);

        // Mostrar los resultados ordenados en la consola
        Console.WriteLine("Numeros Primos: " + string.Join(" ", primeNumbersWithoutDuplicates));
        Console.WriteLine("Numeros que menos se repiten: " + string.Join(" ", leastRepeatedNumbers));
        Console.WriteLine("Numeros que mas se repiten: " + string.Join(" ", mostRepeatedNumbers));
    }
}
