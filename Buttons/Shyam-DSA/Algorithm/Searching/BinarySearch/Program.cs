using System;
namespace BinarySearch;
class Program
{
    public static void Main(string[] args)
    {
        string [] stringarray={"SF3021","SF3023","SF3032","SF3043","SF3053","SF3062","SF3063","SF3067","SF3089","SF3099"};
        char[] chararray={'c','a','f','b','k','h','z','t','m','p','l','d'};
        int[] intarray={12,12,14,22,33,33,35,45,55,67,77};
        double[] doublearray={1.2,1.3,1.4,2.2,3.3,3.4,3.5,4.5,5.5,6.7,7.7};
        System.Console.WriteLine(Binary(intarray,67));
        System.Console.WriteLine(Binary(chararray,'m'));
        System.Console.WriteLine(Binary(stringarray,"SF3067"));
        System.Console.WriteLine(Binary(doublearray,3.3));

    }
    public static int Binary<T>(T[]_array,T key) where T : IComparable<T>
    {
        int left=0;
        int right=_array.Length-1;
        while(left<=right)
        {
            int mid =left+(right-left)/2;
            int compare=_array[mid].CompareTo(key);
            if (compare==0)
            {
                return mid;
            }
            else if(compare<0)
            {
                left=mid+1;
            }
            else
            {
                right=mid-1;
            }
        }
        return -1;
    }
}