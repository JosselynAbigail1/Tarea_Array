using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Array
{
      public class ArrayManipulator(int[] inputArray)
    {
        protected int[] array = inputArray;

        public int[] GetPrimeNumbersWithoutDuplicates()
        {
           
            int[] uniqueNumbers = array.Distinct().ToArray();

           
            int[] primeNumbers = new int[uniqueNumbers.Length];
            int primeCount = 0;

          
            foreach (var number in uniqueNumbers)
            {
                
                if (IsPrime(number))
                {
                    primeNumbers[primeCount++] = number;
                }
            }

           return primeNumbers.Take(primeCount).ToArray();
        }

        public int[] GetLeastRepeatedNumbers()
        {
            var groups = array.GroupBy(x => x);
            var leastRepeatedCount = groups.Min(g => g.Count());

            int[] leastRepeated = new int[array.Length];
            int leastCount = 0;

            foreach (var group in groups)
            {
                if (group.Count() == leastRepeatedCount)
                {
                    leastRepeated[leastCount++] = group.Key;
                }
            }

            return leastRepeated.Take(leastCount).ToArray();
        }

        public int[] GetMostRepeatedNumbers()
        {
            var groups = array.GroupBy(x => x);
            var mostRepeatedCount = groups.Max(g => g.Count());

            int[] mostRepeated = new int[array.Length];
            int mostCount = 0;

            foreach (var group in groups)
            {
                if (group.Count() == mostRepeatedCount)
                {
                    mostRepeated[mostCount++] = group.Key;
                }
            }

            return mostRepeated.Take(mostCount).ToArray();
        }

        protected bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }

}
