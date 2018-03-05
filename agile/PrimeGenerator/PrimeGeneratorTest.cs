using NUnit.Framework;

namespace agile.PrimeGenerator
{
    [TestFixture]
    public class PrimeGeneratorTest
    {
        [Test]
        public void TestPrimes()
        {
            int[] nullArray = agile.PrimeGenerator.PrimeGenerator.GeneratePrimeNumbers(0);
            Assert.AreEqual(nullArray.Length, 0);
            int[] minArray = agile.PrimeGenerator.PrimeGenerator.GeneratePrimeNumbers(2);
            Assert.AreEqual(minArray.Length, 1);
            Assert.AreEqual(minArray[0], 2);
            int[] threeArray = agile.PrimeGenerator.PrimeGenerator.GeneratePrimeNumbers(3);
            Assert.AreEqual(threeArray.Length, 2);
            Assert.AreEqual(threeArray[0], 2);
            Assert.AreEqual(threeArray[1], 3);
            int[] centArray = agile.PrimeGenerator.PrimeGenerator.GeneratePrimeNumbers(100);
            Assert.AreEqual(centArray.Length, 25);
            Assert.AreEqual(centArray[24], 97);
        }
    }
}
