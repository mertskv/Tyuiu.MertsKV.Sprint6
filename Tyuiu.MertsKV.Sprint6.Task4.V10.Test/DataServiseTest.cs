using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint6.Task4.V10.Lib;
namespace Tyuiu.MertsKV.Sprint6.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataServise ds = new DataServise();
            int len = 11;
            double[] wait = new double[len];
            wait[0] = -15.40;
            wait[1] = -13.31;
            wait[2] = -11.36;
            wait[3] = -8.00;
            wait[4] = -2.62;
            wait[5] = 1.83;
            wait[6] = 4.49;
            wait[7] = 6.78;
            wait[8] = 10.58;
            wait[9] = 17.38;
            wait[10] = 23.76;
            double[] res = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
