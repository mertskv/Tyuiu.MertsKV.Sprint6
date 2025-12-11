using System.IO;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MertsKV.Sprint6.Task6.V26.Lib
{
    public class DataServise : ISprint6Task6V26
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] mas = line.Split(' ');
                    for (int i = 0; i < mas.Length - 1; i++)
                    {
                        resStr += mas[mas.Length - 1] + " ";
                        break;
                    }
                }
            }
            return resStr.Trim();

        }
    }
}
