using System.Windows.Forms;
using System.IO;
using Tyuiu.MertsKV.Sprint6.Task4.V10.Lib;
namespace Tyuiu.MertsKV.Sprint6.Task4.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonHelp_MKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студент группы ИСТНб-25-1 Мерц Кристина Викторовна", "Сообщение");
        }
        DataServise ds = new DataServise();

        private void buttonDone_MKV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_MKV.Text);
                int stopStep = Convert.ToInt32(textBoxStop_MKV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                

                this.chartFunction_MKV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_MKV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_MKV.Text = "";

                chartFunction_MKV.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_MKV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_MKV.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_MKV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DataSprint6\OutPutFileTask4V10.txt";
                File.WriteAllText(path, textBoxResult_MKV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    //процесс запуска приложения notepad
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
