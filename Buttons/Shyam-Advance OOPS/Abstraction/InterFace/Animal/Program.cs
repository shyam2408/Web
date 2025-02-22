using System;
using Animal;
namespace DrawingApplication;
class Program
{
    public static void Main(string[]args)
    { 
        Dog dog=new Dog("tommy","sleep","Meat");
        Duck duck=new Duck("Tom","Swim","Rice");
        dog.DisplayData();
        duck.DisplayData();
    }
}