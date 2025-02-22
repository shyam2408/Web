using System;
using System.ComponentModel.DataAnnotations;


namespace BinarySearch
{
    class Program
    {
        public static void Main(string[]args)
        {
            string [] stringarray={"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032","SF3063", "SF3089", "SF3062", "SF3099"};
            char[] chararray={'c','a','f','b','k','h','z','t','m','p','l','d'};
            int[] intarray={45,33,12,55,77,22,33,14,67,12,35};
            double[] doublearray={45,33,12,55,77,22,33,14,67,12,35};
            MergeSort(stringarray);
            MergeSort(chararray);
            MergeSort(intarray);
            MergeSort(doublearray);
            System.Console.WriteLine(string.Join(",",intarray));
            System.Console.WriteLine(string.Join(",",chararray));
            System.Console.WriteLine(string.Join(",",doublearray));
            System.Console.WriteLine(string.Join(",",stringarray));
          
        }

        static void MergeSort<T>(T[] arr) where T :IComparable<T>
        {
            if (arr.Length<=1)
            {return;}
            int mid =arr.Length/2;
            T[] left=new T[mid];
            T[] right=new T[arr.Length-mid];
            Array.Copy(arr,0,left,0,mid);
            Array.Copy(arr,mid,right,0,arr.Length-mid);
            MergeSort(left);
            MergeSort(right);
            Merge(arr,left,right);
        }

        static void Merge<T>(T[]arr,T[]left,T[]right) where T:IComparable<T>
        {
            int i=0,j=0,k=0;
            while(i<left.Length&&j<right.Length)
            {
                if(left[i].CompareTo(right[j])<0)
                {
                    arr[k]=left[i];
                    i++;
                }
                else
                {
                    arr[k]=right[j];
                    j++;
                }
                k++;
            }
            while(i<left.Length)
            {
                arr[k++]=left[i++];
            }
            while(j<right.Length)
            {
                arr[k++]=right[j++];
            }
        }
    
    }
}
