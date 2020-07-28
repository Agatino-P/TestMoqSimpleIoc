using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestMoqSimpleIoc;

namespace TestProject
{

    public class TestGetInteger : IGetInteger
    {
        public int GetInt()
        {
            return 2;
        }
    }
    [TestClass]
    public class Substitute
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<IGetInteger> mockIGetInteger = new Mock<IGetInteger>();
            mockIGetInteger.Setup(m => m.GetInt()).Returns(2);

            ServLocator.IGetInteger = mockIGetInteger.Object;

            IntWrapper intWrapper = new IntWrapper();
            int i = intWrapper.GetFromInterface();
            Assert.AreEqual(i, 2);

        }
    }
}
