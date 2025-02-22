using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arithmatic
{
    public class ArithmaticOperations
    {
        //a.	Create a set of Multiply method inside a class
	    //Method with one argument and display the Square value of a given number.
	   //Method with 2 arguments with same argument type and return result.
	   //Method with 3 arguments with same argument type and return the result. 
	   //Method with 2 arguments with different argument type and return result.
       //Method with 3 arguments with different argument type and return the result. 
       public int Number1 { get; set; }
       public int Number2 { get; set; }
       public int Number3 { get; set; }
       
       public int Multiply(int Number1)
       {
        return Number1*Number1;
       }
       public int Multiply(int Number1,int Number2)
       {
        return Number1*Number2;
       }
       public int Multiply(int Number1,int Number2,int Number3)
       {
        return Number1*Number2*Number3;
       }
        public double Multiply(int Number1,double Number2)
       {
        return Number1*Number2;
       }
        public double Multiply(int Number1,int Number2,double Number3)
       {
        return Number1*Number2*Number3;
       }


    }
}