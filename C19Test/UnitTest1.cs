using C19UnitTesting;

namespace C19Test
{
    [TestClass] // anotace
    public class UnitTest1
    {
        private C19UnitTesting.Calculator calc;

        [TestInitialize]
        public void Initialize()
        {
            calc = new Calculator();
        }

        [TestCleanup]
        public void Cleanup()
        {
        }

        [TestMethod]
        public void TestAddition()
        {
            Assert.AreEqual(2, calc.Addition(1, 1));
            Assert.AreEqual(1, calc.Addition(1, 0));
            Assert.AreEqual(1, calc.Addition(0, 1));
            Assert.AreEqual(0, calc.Addition(0, 0));
            Assert.AreEqual(100001, calc.Addition(100000, 1));
        }

        [TestMethod]
        public void TestAddition2()
        {
            Assert.AreEqual(0, calc.Addition(1, -1));
            Assert.AreEqual(-2, calc.Addition(-1, -1));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(1, calc.Division(1, 1));
            Assert.AreEqual(0, calc.Division(0, 1));
        }

        [TestMethod]
        public void TestDivisionByZero()
        {
            Assert.ThrowsException<ArgumentException>(
                () => calc.Division(1.0,0)
            );
        }
    }
}