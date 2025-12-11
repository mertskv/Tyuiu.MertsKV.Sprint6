using System.Windows.Forms;
using System.IO;
using Tyuiu.MertsKV.Sprint6.Task5.V7.Lib;
namespace Tyuiu.MertsKV.Sprint6.Task5.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataServise ds = new DataServise();
        string path = @"C:\DataSprint6\InPutDataFileTask5V7.txt";


        private void buttonDone_MKV_Click(object sender, EventArgs e)
        {
            dataGridViewResult_MKV.ColumnCount = 2;
            dataGridViewResult_MKV.Columns[0].Width = 20;
            dataGridViewResult_MKV.Columns[1].Width = 50;
            this.chartDiag_MKV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_MKV.ChartAreas[0].AxisY.Title = "Ось Y";
            chartDiag_MKV.Series[0].Points.Clear();
            double[] massive = new double[ds.len];
            massive = ds.LoadFromDataFile(path);
            for (int i = 0; i < massive.Length; i++)
            {
                dataGridViewResult_MKV.Rows.Add(Convert.ToString(i), Convert.ToString(massive[i]));
                chartDiag_MKV.Series[0].Points.AddXY(i, massive[i]);
            }


        }

        private void buttonOpenFile_MKV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_MKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студент группы ИСТНб-25-1 Мерц Кристина Викторовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
