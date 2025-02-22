using System;
using ListDataStructures;

namespace List;

class Program
{
    public static void Main(string[]args)
    {
        CustomList<int> list=new CustomList<int>();
        list.Add(1);
        list.Add(3);
        list.Add(21);
        list.Add(13);
        list.Add(7);
        CustomList<int> numbers=new CustomList<int>();
        numbers.Add(70);
        numbers.Add(80);
        list.AddRange(numbers);
        list.Contain(80);
        foreach(int t in list)
        {
            System.Console.WriteLine(t);
        }
    }
}
