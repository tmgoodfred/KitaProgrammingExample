using KitaProgrammingExample;

namespace KitaProgrammingExampleTests
{
    [TestClass]
    public class KitaProgrammingTests
    {
        [TestMethod]
        public void TestAddition()
        {
            Main KitaMain = new Main();
            int number1 = 2;
            int number2 = 3;
            int result = KitaMain.TryToDoMath(number1, number2);
            Assert.AreEqual((number1+number2), result);
            
        }

        [TestMethod]
        public void TestAdditionOutOfBoundNumbers()
        {
            int number1 = 10;
            int number2 = 2147483646;
            Main KitaMain = new Main();
            Assert.ThrowsException<SystemException>(() => KitaMain.TryToDoMath(number1, number2));
        }
    }
}