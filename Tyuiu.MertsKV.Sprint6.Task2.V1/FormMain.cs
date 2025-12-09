using Tyuiu.MertsKV.Sprint6.Task2.V1.Lib;
namespace Tyuiu.MertsKV.Sprint6.Task2.V1
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

                int startStep = Convert.ToInt32(textBoxStartValue_MKV.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_MKV.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_MKV.Titles.Add("График функции");
                this.chartFunction_MKV.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_MKV.ChartAreas[0].AxisY.Title = "Ось Ү";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_MKV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_MKV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MKV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_MKV.BackColor = Color.Blue;
        }

        private void buttonDone_MKV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_MKV.BackColor = Color.Red;
        }

        private void buttonDone_MKV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_MKV.BackColor = Color.Green;
        }
        private void buttonHelp_MKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИСТНб-25-1 Мерц Кристина Викторовна", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
