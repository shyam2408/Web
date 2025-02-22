using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace QuickSort
{
    class Program
    {
        public static void Main(string[]args)
        {
            System.Console.WriteLine("Sorted array");
            int[] intarray={45,33,12,55,77,22,33,14,67,12,35};
            QuickSort(intarray,0,intarray.Length-1);
            System.Console.WriteLine(string.Join(",",intarray));
        }
          
        public static void QuickSort<T>(T[]arr,int low,int high) where T :IComparable<T>
        {
            if(low<high)
            {
                int pivotIndex=Partitioner( arr,low,high);
                QuickSort(arr,low,pivotIndex-1);
                QuickSort(arr,pivotIndex+1,high);
            }
        }
        static int Partitioner<T>(T[]arr,int low,int high) where T :IComparable<T>
        {
            T pivot=arr[high];
            int i=low-1;

            for(int j=low;j<high;j++)
            {
                if(arr[j].CompareTo(pivot)<0)
                {
                    i++;
                    Swap(arr,i,j);
                }
            }
            Swap(arr,i+1,high);
            return i+1;

        }

        static void Swap<T>(T[] arr,int i,int j) where T :IComparable<T>
        {
            T temp=arr[i];
            arr[i]=arr[j];
            arr[j]=temp;
        }
    }
}
       
