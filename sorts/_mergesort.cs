using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorts
{
    class _mergesort : evaluationInterface
    {
        public int[] performSort(int[] list) {
            merge_sort(list, 0, list.Length);
            return list;
        }

        public void merge(int[] list, int firstEnd, int secondEnd) {
            int i = 0;
            int j = firstEnd;
            int k = 0;
            int[] temp = new int[list.Length];

            while(j<secondEnd && i<j) {
                 if(list[i]>list[j]) {
                    temp[k] = list[j];
                    j++;
                }
                else {
                    temp[k] = list[i];
                    i++;
                }
                k++;
            }

            while(i<firstEnd) {
                temp[k] = list[i];
                i++;
                k++;
            }
           
            while(j<secondEnd) {
                temp[k] = list[j];
                j++;
                k++;
            }

            for(int n = 0; n < secondEnd; n++)
                list[n] = temp[n];
           
        }

        public void merge_sort(int[] list, int start, int end) {
            int mid;
            if (start >= end)
                return;
            else
            {
                mid = (start + end) / 2;
                merge_sort(list, 0, mid);
                merge_sort(list, mid+1, end);
                merge(list, mid+1, end);
            }
        }

    }
}
