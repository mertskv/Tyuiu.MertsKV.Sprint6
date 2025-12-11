using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MertsKV.Sprint6.Task4.V10.Lib
{
    public class DataServise : ISprint6Task4V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Sin(x) + 3) != 0)
                {
                    double y = ((5 * x + 2.5) / (Math.Sin(x) + 3)) + 2 * x + Math.Cos(x);
                    valueArray[count] = Math.Round(y, 2);
                    count++;
                }
                else
                {
                    valueArray[count] = 0;
                }
            }
            return valueArray;
        }
    }
}
