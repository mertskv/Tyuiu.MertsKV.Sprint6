
namespace Tyuiu.MertsKV.Sprint6.Task5.V7
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelOne_MKV = new Panel();
            buttonHelp_MKV = new Button();
            buttonOpenFile_MKV = new Button();
            buttonDone_MKV = new Button();
            groupBoxTask_MKV = new GroupBox();
            textBoxTask_MKV = new TextBox();
            panelTwo_MKV = new Panel();
            groupBoxResult_MKV = new GroupBox();
            dataGridViewResult_MKV = new DataGridView();
            panelThree_MKV = new Panel();
            chartDiag_MKV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelOne_MKV.SuspendLayout();
            groupBoxTask_MKV.SuspendLayout();
            panelTwo_MKV.SuspendLayout();
            groupBoxResult_MKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MKV).BeginInit();
            panelThree_MKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_MKV).BeginInit();
            SuspendLayout();
            // 
            // panelOne_MKV
            // 
            panelOne_MKV.BackColor = SystemColors.ActiveCaption;
            panelOne_MKV.Controls.Add(buttonHelp_MKV);
            panelOne_MKV.Controls.Add(buttonOpenFile_MKV);
            panelOne_MKV.Controls.Add(buttonDone_MKV);
            panelOne_MKV.Controls.Add(groupBoxTask_MKV);
            panelOne_MKV.Dock = DockStyle.Top;
            panelOne_MKV.Location = new Point(0, 0);
            panelOne_MKV.Name = "panelOne_MKV";
            panelOne_MKV.Size = new Size(1004, 125);
            panelOne_MKV.TabIndex = 0;
            // 
            // buttonHelp_MKV
            // 
            buttonHelp_MKV.BackColor = SystemColors.MenuHighlight;
            buttonHelp_MKV.Location = new Point(870, 30);
            buttonHelp_MKV.Name = "buttonHelp_MKV";
            buttonHelp_MKV.Size = new Size(122, 55);
            buttonHelp_MKV.TabIndex = 2;
            buttonHelp_MKV.Text = "Справка";
            buttonHelp_MKV.UseVisualStyleBackColor = false;
            buttonHelp_MKV.Click += buttonHelp_MKV_Click;
            // 
            // buttonOpenFile_MKV
            // 
            buttonOpenFile_MKV.BackColor = Color.MediumTurquoise;
            buttonOpenFile_MKV.Location = new Point(672, 30);
            buttonOpenFile_MKV.Name = "buttonOpenFile_MKV";
            buttonOpenFile_MKV.Size = new Size(128, 55);
            buttonOpenFile_MKV.TabIndex = 2;
            buttonOpenFile_MKV.Text = "Открыть файл";
            buttonOpenFile_MKV.UseVisualStyleBackColor = false;
            buttonOpenFile_MKV.Click += buttonOpenFile_MKV_Click;
            // 
            // buttonDone_MKV
            // 
            buttonDone_MKV.BackColor = Color.Green;
            buttonDone_MKV.Location = new Point(490, 30);
            buttonDone_MKV.Name = "buttonDone_MKV";
            buttonDone_MKV.Size = new Size(125, 55);
            buttonDone_MKV.TabIndex = 1;
            buttonDone_MKV.Text = "Выполнить ";
            buttonDone_MKV.UseVisualStyleBackColor = false;
            buttonDone_MKV.Click += buttonDone_MKV_Click;
            // 
            // groupBoxTask_MKV
            // 
            groupBoxTask_MKV.Controls.Add(textBoxTask_MKV);
            groupBoxTask_MKV.Location = new Point(12, 3);
            groupBoxTask_MKV.Name = "groupBoxTask_MKV";
            groupBoxTask_MKV.Size = new Size(405, 116);
            groupBoxTask_MKV.TabIndex = 0;
            groupBoxTask_MKV.TabStop = false;
            groupBoxTask_MKV.Text = "Условие";
            // 
            // textBoxTask_MKV
            // 
            textBoxTask_MKV.Location = new Point(3, 23);
            textBoxTask_MKV.Multiline = true;
            textBoxTask_MKV.Name = "textBoxTask_MKV";
            textBoxTask_MKV.ReadOnly = true;
            textBoxTask_MKV.Size = new Size(396, 87);
            textBoxTask_MKV.TabIndex = 0;
            textBoxTask_MKV.Text = "Прочитать данные из файла InPutDataFileTask5V7.txt.\r\nВывести в dataGridView числа, больше 5 и построить диаграмму с этими значениями.";
            // 
            // panelTwo_MKV
            // 
            panelTwo_MKV.BackColor = SystemColors.AppWorkspace;
            panelTwo_MKV.Controls.Add(groupBoxResult_MKV);
            panelTwo_MKV.Dock = DockStyle.Left;
            panelTwo_MKV.Location = new Point(0, 125);
            panelTwo_MKV.Name = "panelTwo_MKV";
            panelTwo_MKV.Size = new Size(250, 389);
            panelTwo_MKV.TabIndex = 0;
            // 
            // groupBoxResult_MKV
            // 
            groupBoxResult_MKV.Controls.Add(dataGridViewResult_MKV);
            groupBoxResult_MKV.Location = new Point(3, 6);
            groupBoxResult_MKV.Name = "groupBoxResult_MKV";
            groupBoxResult_MKV.Size = new Size(247, 380);
            groupBoxResult_MKV.TabIndex = 3;
            groupBoxResult_MKV.TabStop = false;
            groupBoxResult_MKV.Text = "Вывод данных:";
            // 
            // dataGridViewResult_MKV
            // 
            dataGridViewResult_MKV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_MKV.Dock = DockStyle.Fill;
            dataGridViewResult_MKV.Location = new Point(3, 23);
            dataGridViewResult_MKV.Name = "dataGridViewResult_MKV";
            dataGridViewResult_MKV.RowHeadersWidth = 51;
            dataGridViewResult_MKV.Size = new Size(241, 354);
            dataGridViewResult_MKV.TabIndex = 1;
            // 
            // panelThree_MKV
            // 
            panelThree_MKV.BackColor = SystemColors.Info;
            panelThree_MKV.Controls.Add(chartDiag_MKV);
            panelThree_MKV.Dock = DockStyle.Fill;
            panelThree_MKV.Location = new Point(250, 125);
            panelThree_MKV.Name = "panelThree_MKV";
            panelThree_MKV.Size = new Size(754, 389);
            panelThree_MKV.TabIndex = 0;
            // 
            // chartDiag_MKV
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_MKV.ChartAreas.Add(chartArea1);
            chartDiag_MKV.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDiag_MKV.Legends.Add(legend1);
            chartDiag_MKV.Location = new Point(0, 0);
            chartDiag_MKV.Name = "chartDiag_MKV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_MKV.Series.Add(series1);
            chartDiag_MKV.Size = new Size(754, 389);
            chartDiag_MKV.TabIndex = 0;
            chartDiag_MKV.Text = "Diag";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 514);
            Controls.Add(panelThree_MKV);
            Controls.Add(panelTwo_MKV);
            Controls.Add(panelOne_MKV);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Спринт 6 | Таск 5 | Вариант 7 | Мерц К.В";
            panelOne_MKV.ResumeLayout(false);
            groupBoxTask_MKV.ResumeLayout(false);
            groupBoxTask_MKV.PerformLayout();
            panelTwo_MKV.ResumeLayout(false);
            groupBoxResult_MKV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MKV).EndInit();
            panelThree_MKV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag_MKV).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panelOne_MKV;
        private Panel panelTwo_MKV;
        private Panel panelThree_MKV;
        private Button buttonHelp_MKV;
        private Button buttonOpenFile_MKV;
        private Button buttonDone_MKV;
        private GroupBox groupBoxTask_MKV;
        private TextBox textBoxTask_MKV;
        private GroupBox groupBoxResult_MKV;
        private DataGridView dataGridViewResult_MKV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_MKV;
    }
}
