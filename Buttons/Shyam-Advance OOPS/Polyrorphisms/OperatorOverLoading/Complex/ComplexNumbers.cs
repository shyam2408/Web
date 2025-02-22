using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complex
{
    public class ComplexNumbers
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public static ComplexNumbers operator +(ComplexNumbers number1,ComplexNumbers number2)
        {
            ComplexNumbers res=new ComplexNumbers(0,0);
            res.Real=number1.Real+number2.Real;
            res.Imaginary=number1.Imaginary+number2.Imaginary;
            return res;
        }
        public static ComplexNumbers operator -(ComplexNumbers number1,ComplexNumbers number2)
        {
            ComplexNumbers res=new ComplexNumbers(0,0);
            res.Real=number1.Real-number2.Real;
            res.Imaginary=number1.Imaginary-number2.Imaginary;
            return res;
        }
         public static bool operator ==(ComplexNumbers number1,ComplexNumbers number2)
        {
            
            return number1.Real==number2.Real &&number2.Imaginary==number1.Imaginary;
        }
         public static bool operator !=(ComplexNumbers number1,ComplexNumbers number2)
        {
            
            return !(number1==number2);
        }

        public static bool operator >(ComplexNumbers number1,ComplexNumbers number2)
        {
            
            return number1.Real*number1.Real+number1.Imaginary*number1.Imaginary>number2.Real*number2.Real+number2.Imaginary*number2.Imaginary;
        }
        public static bool operator <(ComplexNumbers number1,ComplexNumbers number2)
        {
            
            return number1>number2;
        }
       
       
        public ComplexNumbers(int real,int imaginary)
        {
            Real=real;
            Imaginary=imaginary;
        }
        public void Display()
        {
            System.Console.WriteLine($"RESULT : {Real}+{Imaginary}j");
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        // public override int GetHashCode()
        // {
        //     throw new NotImplementedException();
        // }
    }
}