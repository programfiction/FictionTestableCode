using System;

namespace ConsoleAppToTest
{
    public class TestableInvoiceGenerator
    {
        public decimal GetTotal(decimal parts, decimal service, decimal discount)
        {
            return parts + service + discount;
        }
    }
}
