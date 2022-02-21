using System;
namespace Array
{
    class Program
    {
        static void Main(String[] args)
        {
            bool find = false;
            int[] array = { 70, 80, 90, 20 };
            int search = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (search == array[i])
                    find = true;
                break;
            }
            if (find)

            {
                Console.WriteLine("Found value");
            }
            else
            {
                Console.WriteLine("Not Match");
            }
        }
    }
}
