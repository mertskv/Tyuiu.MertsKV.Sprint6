using System.Windows.Forms;
using Tyuiu.MertsKV.Sprint6.Task0.V26.Lib;
namespace Tyuiu.MertsKV.Sprint6.Task0.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_MKV_Click(object sender, EventArgs e)
        {
            DataServise ds = new DataServise();
            try
            {
                textBoxResult_MKV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_MKV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_MKV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_MKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0, вариант 26 выполнила студентка группы ИСТНб-25-1 Мерц Кристина Викторовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
