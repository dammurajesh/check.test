using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace PrimeService.Tests
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod()]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var primeService = new PrimeServices();
            bool result = primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}
