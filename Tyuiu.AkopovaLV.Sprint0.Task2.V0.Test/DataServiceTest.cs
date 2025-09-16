using Tyuiu.AkopovaLV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AkopovaLV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Luda";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Hello, Luda", res);
        }
    }
}
