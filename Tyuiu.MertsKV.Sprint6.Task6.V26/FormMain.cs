using System.Windows.Forms;
using System;
using System.IO;
using Tyuiu.MertsKV.Sprint6.Task6.V26.Lib;
namespace Tyuiu.MertsKV.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataServise ds = new DataServise();

        private void buttonOpenFile_MKV_Click(object sender, EventArgs e)
        {

            openFileDialogTask_MKV.ShowDialog();
            openFilePath = openFileDialogTask_MKV.FileName;
            textBoxIn_MKV.Text = File.ReadAllText(openFilePath);
            groupBoxInPutDataFile_MKV.Text = groupBoxOutPutDataFileTask_MKV.Text + " - " + openFileDialogTask_MKV.FileName;
            buttonDone_MKV.Enabled = true;
        }

        private void buttonHelp_MKV_Click_1(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_MKV_Click(object sender, EventArgs e)
        {

            textBoxOut_MKV.Text = ds.CollectTextFromFile(openFilePath);
        }

       
    }
}
