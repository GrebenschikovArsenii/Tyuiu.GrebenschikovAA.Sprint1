using Tyuiu.GrebenschikovAA.Sprint1.Task4.V8.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint1.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            double x = 1, y = 0;
            Assert.AreEqual(1, ds.Calculate(x, y));
        }
    }
}