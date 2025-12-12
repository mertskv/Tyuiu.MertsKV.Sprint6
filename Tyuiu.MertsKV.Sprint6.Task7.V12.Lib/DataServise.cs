using System.IO;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MertsKV.Sprint6.Task7.V12.Lib
{
    public class DataServise : ISprint6Task7V12
    {
        public int[,] GetMatrix(string path)
        {
            string fileDta = File.ReadAllText(path);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);

                }
            }
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    if (arrayValues[i, 8] != 10)
                    {
                        arrayValues[i, 8] = 0;
                    }
                }
            }
            return arrayValues;

        }
    }
}
