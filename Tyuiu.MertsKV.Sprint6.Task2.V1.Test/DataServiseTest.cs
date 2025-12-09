using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint6.Task2.V1.Lib;
namespace Tyuiu.MertsKV.Sprint6.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataServise ds = new DataServise();

            double[] res = ds.GetMassFunction(-5, 5);

            double[] wait = { 20.36, 15.42, 10.99, 7.43, 4.33, 1, 0, -8.87, -13.03, -16.53, -19.6 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
