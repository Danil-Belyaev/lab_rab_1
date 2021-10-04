using System;

namespace lr1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[25];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
                Console.Write(array[i] + " ");
            }

            int min = array[0];
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            if (min < 0)
            {
                Console.WriteLine("\nРазность наибольшего и наименьшего числа: " + (max + min));
            }
            else
            {
                Console.WriteLine("\nРазность наибольшего и наименьшего числа: " + (max - min));
            }
        }
    }
}
