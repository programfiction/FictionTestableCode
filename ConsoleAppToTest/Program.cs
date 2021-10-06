using System;
// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Security.AccessControl;

namespace ConsoleAppToTest
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Invoice Printer!");

            //Old format of code which is very tightly coupled not easy to test.
            var parts = 100m;
            var total = parts + 10.00m;
            Console.WriteLine("Total Price: $" + total);

            //New style of writing code by refactoring code
            TestableInvoiceGenerator objInvoice = new TestableInvoiceGenerator();
            total = objInvoice.GetTotal(100m, 10m, 1m);
            Console.WriteLine("Total Price: $" + total);
        }
    }
}
