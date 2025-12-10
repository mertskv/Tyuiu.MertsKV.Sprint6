using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Tyuiu.MertsKV.Sprint6.Task3.V22.Lib;
namespace Tyuiu.MertsKV.Sprint6.Task3.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataServise ds = new DataServise();

        int[,] mtrx = { { 17, 0, 19, -8, -1 },
                        { 9, 4, -5, 7, 15 },
                        { 11, 13, 4, -4, -14 },
                        { 11, 14, 5, -15, 16 },
                        { 2, -14, -2, 11, 11 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.GetUpperBound(1) + 1;
            dataGridViewMatrix_MKV.ColumnCount = cols;
            dataGridViewMatrix_MKV.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix_MKV.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix_MKV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_MKV_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(mtrx);

            int rows = result.GetLength(0);
            int cols = result.GetLength(1);

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    dataGridViewMatrix_MKV.Rows[i].Cells[j].Value = result[i, j];

            textBoxResult_MKV.Text = "17, 0, 19, -8, -1";
        }

        private void buttonHelp_MKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнила студент группы ИСТНб-25-1 Мерц Кристина Викторовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}  

