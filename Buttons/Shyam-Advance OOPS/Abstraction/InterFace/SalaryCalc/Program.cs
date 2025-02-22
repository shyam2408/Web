using System;

namespace SalaryCalc;
class Program
{
    public static void Main(string[]args)
    { 
        OnlineTransaction transaction1=new OnlineTransaction(1234,"11/11/1111");
        Purchase purchase1=new Purchase("101","dress",4,100);
        Purchase purchase2=new Purchase("103","shoes",5,100);
        Purchase purchase3=new Purchase("104","phone",6,100);
        transaction1.LogPurchase(purchase1);
        transaction1.LogPurchase(purchase2);
        transaction1.LogPurchase(purchase3);
        transaction1.Displaybill();
        OflineTransaction transaction2=new OflineTransaction(1234,"11/11/1111");
        Purchase purchase4=new Purchase("105","dress",4,100);
        Purchase purchase5=new Purchase("106","dress",5,200);
        Purchase purchase6=new Purchase("107","dress",6,300);
        transaction2.LogPurchase(purchase4);
        transaction2.LogPurchase(purchase5);
        transaction2.LogPurchase(purchase6);
        transaction2.Displaybill();
    }
}