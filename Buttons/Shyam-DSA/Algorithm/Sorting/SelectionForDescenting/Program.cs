using System;

namespace selection;


    class Program
    {
        public static void Main(string[]args) 
        {
            string [] stringarray={"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032","SF3063", "SF3089", "SF3062", "SF3099"};
            char[] chararray={'c','a','f','b','k','h','z','t','m','p','l','d'};
            int[] intarray={45,33,12,55,77,22,33,14,67,12,35};
            double[] doublearray={45,33,12,55,77,22,33,14,67,12,35};
            SelectionSort(stringarray);
            SelectionSort(chararray);
            SelectionSort(intarray);
            SelectionSort(doublearray);
            System.Console.WriteLine(string.Join(",",intarray));
            System.Console.WriteLine(string.Join(",",chararray));
            System.Console.WriteLine(string.Join(",",doublearray));
            System.Console.WriteLine(string.Join(",",stringarray));
        }

        public static void SelectionSort<T>(T[]array) where T :IComparable<T>
        
        {
            for(int i=0;i<array.Length;i++)
           {
            int min=i;
            for(int j=i;j<array.Length;j++)
            {
                if(array[j].CompareTo(array[min])>0)
                {
                    min=j;
                }    
            }
            T temp=array[i];
            array[i]=array[min];
            array[min]=temp;
           }
        }
    }


