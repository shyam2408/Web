using System;
using E_CommerceApplicationforConsumerElectronicsProducts;

namespace Syncart
{
    class Program
    {
        public static void Main(string[]args)
        {
            Operations operation=new Operations();
            operation.Default();
            operation.MainMenu();
        }
    }
}