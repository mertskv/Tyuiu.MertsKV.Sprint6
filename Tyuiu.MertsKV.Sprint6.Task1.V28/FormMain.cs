using System.Windows.Forms;
using Tyuiu.MertsKV.Sprint6.Task1.V28.Lib;
namespace Tyuiu.MertsKV.Sprint6.Task1.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataServise ds = new DataServise();

        private void buttonDone_MKV_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_MKV.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_MKV.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_MKV.Text = "";
                textBoxResult_MKV.AppendText("+--------+--------+" + Environment.NewLine);
                textBoxResult_MKV.AppendText("+     x     |    f(x)   +" + Environment.NewLine);
                textBoxResult_MKV.AppendText("+--------+--------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,6:d}     |  {1,6:f2}   | ", startValue, valueArray[i]);
                    textBoxResult_MKV.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_MKV.AppendText("+--------+--------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_MKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студент ИСТНб-25-1 Мерц Кристина Викторовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
