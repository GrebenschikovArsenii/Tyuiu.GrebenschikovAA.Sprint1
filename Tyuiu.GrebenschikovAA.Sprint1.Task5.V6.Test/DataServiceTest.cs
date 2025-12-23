using Tyuiu.GrebenschikovAA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            int f = 15;
            int res = ds.Calculate(f);
            Assert.AreEqual(1, res);
        }
    }
}