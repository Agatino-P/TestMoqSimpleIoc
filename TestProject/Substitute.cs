using GalaSoft.MvvmLight.Ioc;
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
            Mock<IGetInteger> mockGetInteger = new Mock<IGetInteger>();
            mockGetInteger.Setup(m => m.GetInt()).Returns(2);

            ServLocator.getInteger = mockGetInteger.Object;
            int j = ServLocator.getInteger.GetInt();
            IntWrapper intWrapper = new IntWrapper();
            int i = intWrapper.GetFromInterface();
            Assert.AreEqual(i, 2);

        }
    }
}
