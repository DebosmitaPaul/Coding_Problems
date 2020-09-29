
using System;

namespace MyLearnings
{
    public class HeapSortAlgo
    {
        public static void Main02()
        {
            int[] arr = {15,5,20,1,17,10,30};
            int n = arr.Length;

            HeapSort(arr,n);
            Console.WriteLine("Sorted array is");
            printArray(arr);
        }

        public static void HeapSort(int[] arr,int n)
        {
            //build max heap
            for (int i = n/2-1; i>=0; i--)
            {
                MaxHepify(arr,n,i);
            }

            //Deleting
            for (int i = n-1; i >0 ; i--)
            {
                int temp = arr[i];
                arr[i] = arr[0];
                arr[0] = temp;

                MaxHepify(arr,i,0);
            }
        }

        static void MaxHepify(int[] arr, int n,int i)   //0(n)
        {
            int largest = i; 
            int lc = 2 * i+1;
            int rc = 2 * i + 2;
            while (lc < n && arr[largest] < arr[lc]) 
            {
                largest = lc;
            }
            while (rc < n && arr[largest] < arr[rc])
            {
                largest = rc;
            }

            if (largest!= i) // largest is updated 
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                MaxHepify(arr,n,largest );
            }
        }

        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Read();
        }
    }
}
