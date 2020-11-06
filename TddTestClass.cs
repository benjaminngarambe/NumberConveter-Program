using NUnit.Framework;

namespace NumberConveterProgram
{
    [TestFixture]
    internal class TddTestClass
    {
        [Test]
        public void Test1()
        {
            DecimalProgram DecimalToEverything = new DecimalProgram("10");
            string result = DecimalToEverything.DecimalToHexa();
            Assert.That(result, Is.EqualTo("12"));
        }

        [Test]
        public void Test2()
        {
            DecimalProgram DecimalToEverything = new DecimalProgram("10");
            string result = DecimalToEverything.DecimalToBinary();
            Assert.That(result, Is.EqualTo("1010"));
        }

        [Test]
        public void Test3()
        {
            DecimalProgram DecimalToEverything = new DecimalProgram("10");
            string result = DecimalToEverything.DecimalToOctal();
            Assert.That(result, Is.EqualTo("12"));
        }
    }
}