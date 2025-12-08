using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MertsKV.Sprint6.Task0.V26.Lib
{
    public class DataServise : ISprint6Task0V26
    {
        public double Calculate(int x)
        {
            double res = Math.Round((Math.Pow(x, 2) + 1) / (3 * x + 4), 3);
            return res;
        }
    }
}
