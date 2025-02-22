using System;
using System.Security.Cryptography.X509Certificates;
namespace Linear;
class Program
{
    public static void Main(string[] args)
    {
        string [] stringarray={"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032","SF3063", "SF3089", "SF3067", "SF3099"};
        char[] chararray={'c','a','f','b','k','h','z','t','m','p','l','d'};
        int[] intarray={45,33,12,55,77,22,33,14,67,12,35};
        double[] doublearray={4.5,3.3,1.2,5.5,7.7,2.2,3.3,1.4,6.7,1.2,3.5};
        System.Console.WriteLine(Linear(intarray,67));
        System.Console.WriteLine(Linear(chararray,'m'));
        System.Console.WriteLine(Linear(stringarray,"SF3067"));
        System.Console.WriteLine(Linear(doublearray,3.5));

    }
    public static int Linear<T>(T[] _array,T key) where T : IComparable<T>
    { 
        for(int i=0;i<_array.Length;i++)
        {
            if(_array[i].Equals(key))
            {
                return i;
            }
        }
        return -1;
    }
}