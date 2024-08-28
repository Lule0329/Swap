using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Swap
            Console.WriteLine("Vilka positioner vill du byta?");
            string index1 = Console.ReadLine();
            string index2 = Console.ReadLine();
            
            int[] swapTestData = { 8, 4, 6, 9 };
            Console.WriteLine("Demonstration av Swap:");
            Console.WriteLine("Före: " + string.Join(",", swapTestData));
            Swap(int.Parse(index1), int.Parse(index2), swapTestData); // ska fungera med olika index!
            Console.WriteLine("Efter: " + string.Join(",", swapTestData));
        }

        public static void Swap(int index1, int index2, int[] numbers)
        {
            int a = numbers[index1];
            int b = numbers[index2];

            numbers[index1] = b;
            numbers[index2] = a;
        }
    }
}
