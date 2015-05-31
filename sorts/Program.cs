using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 5, 7, 9, 3, 6, 17, 12}; //sample list to sort

            var bubbleSort = new _bubblesort();
            int[] bSortedList = bubbleSort.performSort(list);

            string bOutput = "Bubble Sorted Output: ";
            for (int i = 0; i < bSortedList.Length; i++) {
                bOutput += bSortedList[i] + " ";
            }

            Console.WriteLine(bOutput);
            Console.ReadLine();

        }
    }
}
