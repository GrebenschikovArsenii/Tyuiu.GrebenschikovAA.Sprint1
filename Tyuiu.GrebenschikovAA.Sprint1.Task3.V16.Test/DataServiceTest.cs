using Tyuiu.GrebenschikovAA.Sprint1.Task3.V16.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            double x1 = 2, x2 = 3;
            DataService ds = new DataService();
            Assert.AreEqual(-5, ds.CoeffOfQuadraticEquation(x1, x2));
        }
    }
}