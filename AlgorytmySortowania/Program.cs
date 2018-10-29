using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmySortowania
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notSort = new int[100];
            Random rand = new Random();

            Console.WriteLine("Nieposortowana tablica: \n");

            for(int i=0; i<notSort.Length; i++)
            {
                notSort[i] = rand.Next(100);
                Console.Write(notSort[i] + " ");
            }

            Console.WriteLine("\n");

            QuickSort quick = new QuickSort();
            BubbleSort bubble = new BubbleSort();

            bubble.Sort(notSort);
            bubble.Print();

            Console.WriteLine("\n");

            quick.Sort(notSort);
            quick.Print();

            Console.WriteLine("\n");
        }
    }
}
