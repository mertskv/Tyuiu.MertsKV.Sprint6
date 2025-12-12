using Tyuiu.MertsKV.Sprint6.Task7.V12.Lib;
using System.IO;
using System.Windows.Forms;
namespace Tyuiu.MertsKV.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_MKV.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
            saveFileDialogMatrix_MKV.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
        }
        static string OpenFilePath;
        DataServise ds = new DataServise();

        private void buttonSaveFile_MKV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_MKV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_MKV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_MKV.ShowDialog();

            string path = saveFileDialogMatrix_MKV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_MKV.RowCount;
            int columns = dataGridViewOutPut_MKV.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_MKV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_MKV.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDone_MKV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(OpenFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPut_MKV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }


            }
            buttonSaveFile_MKV.Enabled = true;
        }

        static int rows;
        static int columns;

        public static int[,] LoadFromFileDta(string FilePath)
        {
            string fileDta = File.ReadAllText(FilePath);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_MKV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MKV.ShowDialog();
            OpenFilePath = openFileDialogTask_MKV.FileName;

            int[,] arrayValues = LoadFromFileDta(OpenFilePath);
            dataGridViewInPut_MKV.ColumnCount = columns;
            dataGridViewInPut_MKV.RowCount = rows;
            dataGridViewOutPut_MKV.ColumnCount = columns;
            dataGridViewOutPut_MKV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_MKV.Columns[i].Width = 25;
                dataGridViewOutPut_MKV.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInPut_MKV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            arrayValues = ds.GetMatrix(OpenFilePath);
            buttonDone_MKV.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_MKV.ColumnCount = 50;
            dataGridViewOutPut_MKV.ColumnCount = 50;
            dataGridViewInPut_MKV.RowCount = 50;
            dataGridViewOutPut_MKV.RowCount = 50;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_MKV.Columns[i].Width = 25;
                dataGridViewOutPut_MKV.Columns[i].Width = 25;
            }
        }

        private void buttonHelp_MKV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpenFile_MKV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MKV.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MKV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MKV.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_MKV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MKV.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_MKV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MKV.ToolTipTitle = "Справка";
        }
    }
}
