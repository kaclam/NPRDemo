using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmySortowania
{
    public class BubbleSort
    {
        public int[] SortedTab = new int[100];

        public async void Sort(int[] tab)
        {
            int t;

            for(int i=0; i<SortedTab.Length; i++)
            {
                SortedTab[i] = tab[i];
            }

            for (int p = 0; p <= SortedTab.Length - 2; p++)
            {
                for (int i = 0; i <= SortedTab.Length - 2; i++)
                {
                    if (SortedTab[i] > SortedTab[i + 1])
                    {
                        t = SortedTab[i + 1];
                        SortedTab[i + 1] = SortedTab[i];
                        SortedTab[i] = t;
                    }
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Posortowana tablica za pomocą BubbleSort: \n");
            for (int i = 0; i < SortedTab.Length; i++)
            {
                Console.Write(SortedTab[i] + " ");
            }
        }
    }
}
