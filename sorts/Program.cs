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
            int[] list = { 1, 5, 7, 9, 3, 6, 17, 12 }; //sample list to sort

            var sort = new _mergesort();
            int[] sortedList = sort.performSort(list);

            string output = "Sorted Output: ";
            for (int i = 0; i < sortedList.Length; i++)
                output +=sortedList[i] + " ";
            

            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}
