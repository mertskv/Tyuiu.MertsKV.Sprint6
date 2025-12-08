using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint6.Task0.V26.Lib;
namespace Tyuiu.MertsKV.Sprint6.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataServise ds = new DataServise();
            double res = ds.Calculate(3);
            double wait = 0.769;
            Assert.AreEqual(wait, res);
        }
    }
}
