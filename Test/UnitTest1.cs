using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(OOP_lab_4_17_1.Student.StudentRating(100), "Вiтаємо вiдмiнника");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(OOP_lab_4_17_1.Student.StudentRating(77), "Можна вчитися краще");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(OOP_lab_4_17_1.Student.StudentRating(51), "Варто бiльше уваги придiляти навчанню");
        }
    }
}
