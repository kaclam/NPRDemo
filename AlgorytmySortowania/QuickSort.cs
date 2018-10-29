using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmySortowania
{


    public class QuickSort
    {

        public int[] SortedTab = new int[100];

        private static void Quick_Sort(int[] tab, int p, int r)
        {
            int q;

            if (p < r)
            {
                q = Partition(tab, p, r);
                Quick_Sort(tab, p, q);
                Quick_Sort(tab, q + 1, r);
            }
        }

        private static int Partition(int[] tab, int p, int r)
        {
            int x = tab[p];
            int i = p, j = r, w;


            while (true)
            {
                while (tab[j] > x) // dopoki elementy sa wieksze od x
                {
                    j--;
                    
                }

                while (tab[i] < x) // dopoki elementy sa mniejsze od x
                {
                    i++;
                    
                }

         

                if (i < j) // zamieniamy miejscami gdy i < j
                {
                    w = tab[i];
                    tab[i] = tab[j];
                    tab[j] = w;
                    i++;
                    j--;
                }

                else
                    return j;
            }
        }
        public async void Sort(int[] tab)
        {
            for (int i = 0; i < SortedTab.Length; i++)
            {
                SortedTab[i] = tab[i];
            }

            Quick_Sort(SortedTab, 0, SortedTab.Length-1);
        }

        public void Print()
        {
            Console.WriteLine("Posortowana tablica za pomocą QuickSort: \n");
            for (int i = 0; i < SortedTab.Length; i++)
            {
                Console.Write(SortedTab[i] + " ");
            }
        }

    }
}
