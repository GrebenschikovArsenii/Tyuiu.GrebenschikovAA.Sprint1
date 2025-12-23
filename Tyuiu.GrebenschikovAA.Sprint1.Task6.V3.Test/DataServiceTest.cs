using Tyuiu.GrebenschikovAA.Sprint1.Task6.V3.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMethodValid()
        {
            DataService ds = new DataService();
            string text = "Казак помыл машину";
            string res = ds.LastLetterWord(text);
            Assert.AreEqual("клу", res);
        }
    }
}