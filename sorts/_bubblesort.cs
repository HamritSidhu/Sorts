using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorts
{
    class _bubblesort : evaluationInterface
    {
        public int[] performSort(int[] list) {
            int swapCount = 0;
            int temp = 0;
            while (true)
            {
                swapCount = 0;
                for (int i = 0; i < list.Length - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                        swapCount++;
                    }
                }
                if (swapCount == 0)
                    break;
            }
            return list;
        }
    }
}
