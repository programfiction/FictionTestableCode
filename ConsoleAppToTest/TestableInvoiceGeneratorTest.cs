using System;
using NUnit.Framework;

namespace ConsoleAppToTest
{
    [TestFixture]
    public class TestableInvoiceGeneratorTest
    {
        private TestableInvoiceGenerator _Invoice;

        public TestableInvoiceGeneratorTest(TestableInvoiceGenerator invoice)
        {
            _Invoice = invoice;
        }

        [SetUp]
        public void Setup()
        {
            _Invoice= new TestableInvoiceGenerator();
        }

        [Test]
        public void TestInvoiceGeneratorV1()
        {
            var result= _Invoice.GetTotal(100m,10m,1m);
            Assert.That(result,Is.EqualTo(111m));

        }
        
    }
}