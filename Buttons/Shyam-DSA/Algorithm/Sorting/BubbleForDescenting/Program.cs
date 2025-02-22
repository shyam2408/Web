namespace Bubble;

    class Program
    {
        public static void Main(string[]args)
        {
            string [] stringarray={"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032","SF3063", "SF3089", "SF3062", "SF3099"};
            char[] chararray={'c','a','f','b','k','h','z','t','m','p','l','d'};
            int[] intarray={45,33,12,55,77,22,33,14,67,12,35};
            double[] doublearray={45,33,12,55,77,22,33,14,67,12,35};
            Bubble(stringarray);
            Bubble(chararray);
            Bubble(intarray);
            Bubble(doublearray);
            System.Console.WriteLine(string.Join(",",intarray));
            System.Console.WriteLine(string.Join(",",chararray));
            System.Console.WriteLine(string.Join(",",doublearray));
            System.Console.WriteLine(string.Join(",",stringarray));
        }
        public static void Bubble<T>(T []array) where T : IComparable<T>
        {
            for(int i =0;i<array.Length;i++)
            {
                for(int j=0;j<array.Length-i-1;j++)
                {
                    if (array[j].CompareTo(array[j+1])<0)
                    {
                        T temp=array[j];
                        array[j]=array[j+1];
                        array[j+1]=temp;
                    }
                }
            }
        }
    }
