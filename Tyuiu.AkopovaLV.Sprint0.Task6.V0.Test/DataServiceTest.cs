using Tyuiu.AkopovaLV.Sprint0.Task6.V0.Lib;
namespace Tyuiu.AkopovaLV.Sprint0.Task6.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var nambers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(nambers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckSubtractionArrayValid()
        {
            var nambers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(nambers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckMultiplicationArrayValid()
        {
            var nambers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(nambers);
            Assert.AreEqual(15, res);
        }
    }
}
