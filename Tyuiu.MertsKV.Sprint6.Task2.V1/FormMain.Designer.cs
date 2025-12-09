namespace Tyuiu.MertsKV.Sprint6.Task2.V1
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
            groupBoxTask_MKV = new GroupBox();
            textBoxTask_MKV = new TextBox();
            groupBoxOne_MKV = new GroupBox();
            textBoxStopValue_MKV = new TextBox();
            textBoxStartValue_MKV = new TextBox();
            textBoxOne_MKV = new TextBox();
            buttonDone_MKV = new Button();
            buttonHelp_MKV = new Button();
            groupBoxResult_MKV = new GroupBox();
            chartFunction_MKV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_MKV = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Columns2 = new DataGridViewTextBoxColumn();
            groupBoxTask_MKV.SuspendLayout();
            groupBoxOne_MKV.SuspendLayout();
            groupBoxResult_MKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MKV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_MKV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_MKV
            // 
            groupBoxTask_MKV.Controls.Add(textBoxTask_MKV);
            groupBoxTask_MKV.Location = new Point(0, 1);
            groupBoxTask_MKV.Name = "groupBoxTask_MKV";
            groupBoxTask_MKV.Size = new Size(463, 266);
            groupBoxTask_MKV.TabIndex = 0;
            groupBoxTask_MKV.TabStop = false;
            groupBoxTask_MKV.Text = "Условие";
            // 
            // textBoxTask_MKV
            // 
            textBoxTask_MKV.Location = new Point(6, 26);
            textBoxTask_MKV.Multiline = true;
            textBoxTask_MKV.Name = "textBoxTask_MKV";
            textBoxTask_MKV.ReadOnly = true;
            textBoxTask_MKV.Size = new Size(466, 219);
            textBoxTask_MKV.TabIndex = 1;
            textBoxTask_MKV.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции. ";
            // 
            // groupBoxOne_MKV
            // 
            groupBoxOne_MKV.Controls.Add(textBoxStopValue_MKV);
            groupBoxOne_MKV.Controls.Add(textBoxStartValue_MKV);
            groupBoxOne_MKV.Controls.Add(textBoxOne_MKV);
            groupBoxOne_MKV.Location = new Point(6, 273);
            groupBoxOne_MKV.Name = "groupBoxOne_MKV";
            groupBoxOne_MKV.Size = new Size(257, 113);
            groupBoxOne_MKV.TabIndex = 1;
            groupBoxOne_MKV.TabStop = false;
            groupBoxOne_MKV.Text = "Ввод данных:";
            // 
            // textBoxStopValue_MKV
            // 
            textBoxStopValue_MKV.Location = new Point(156, 77);
            textBoxStopValue_MKV.Name = "textBoxStopValue_MKV";
            textBoxStopValue_MKV.Size = new Size(104, 27);
            textBoxStopValue_MKV.TabIndex = 2;
            textBoxStopValue_MKV.Text = "5";
            // 
            // textBoxStartValue_MKV
            // 
            textBoxStartValue_MKV.Location = new Point(6, 77);
            textBoxStartValue_MKV.Name = "textBoxStartValue_MKV";
            textBoxStartValue_MKV.Size = new Size(93, 27);
            textBoxStartValue_MKV.TabIndex = 2;
            textBoxStartValue_MKV.Text = "-5";
            // 
            // textBoxOne_MKV
            // 
            textBoxOne_MKV.Location = new Point(6, 37);
            textBoxOne_MKV.Multiline = true;
            textBoxOne_MKV.Name = "textBoxOne_MKV";
            textBoxOne_MKV.ReadOnly = true;
            textBoxOne_MKV.Size = new Size(265, 34);
            textBoxOne_MKV.TabIndex = 2;
            textBoxOne_MKV.Text = "Старт шага:             Конец шага:";
            // 
            // buttonDone_MKV
            // 
            buttonDone_MKV.BackColor = Color.Green;
            buttonDone_MKV.Location = new Point(285, 392);
            buttonDone_MKV.Name = "buttonDone_MKV";
            buttonDone_MKV.Size = new Size(97, 76);
            buttonDone_MKV.TabIndex = 2;
            buttonDone_MKV.Text = "Выполнить";
            buttonDone_MKV.UseVisualStyleBackColor = false;
            buttonDone_MKV.Click += buttonDone_MKV_Click;
            buttonDone_MKV.MouseDown += buttonDone_MKV_MouseDown;
            buttonDone_MKV.MouseEnter += buttonDone_MKV_MouseEnter;
            buttonDone_MKV.MouseLeave += buttonDone_MKV_MouseLeave;
            // 
            // buttonHelp_MKV
            // 
            buttonHelp_MKV.BackColor = SystemColors.Highlight;
            buttonHelp_MKV.Location = new Point(162, 392);
            buttonHelp_MKV.Name = "buttonHelp_MKV";
            buttonHelp_MKV.Size = new Size(94, 75);
            buttonHelp_MKV.TabIndex = 3;
            buttonHelp_MKV.Text = "Справка";
            buttonHelp_MKV.UseVisualStyleBackColor = false;
            buttonHelp_MKV.Click += buttonHelp_MKV_Click;
            // 
            // groupBoxResult_MKV
            // 
            groupBoxResult_MKV.Controls.Add(chartFunction_MKV);
            groupBoxResult_MKV.Controls.Add(dataGridViewFunction_MKV);
            groupBoxResult_MKV.Location = new Point(478, 12);
            groupBoxResult_MKV.Name = "groupBoxResult_MKV";
            groupBoxResult_MKV.Size = new Size(558, 473);
            groupBoxResult_MKV.TabIndex = 4;
            groupBoxResult_MKV.TabStop = false;
            groupBoxResult_MKV.Text = "Вывод данных:                                                                                            Результат";
            // 
            // chartFunction_MKV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_MKV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_MKV.Legends.Add(legend1);
            chartFunction_MKV.Location = new Point(180, 78);
            chartFunction_MKV.Name = "chartFunction_MKV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_MKV.Series.Add(series1);
            chartFunction_MKV.Size = new Size(509, 340);
            chartFunction_MKV.TabIndex = 5;
            // 
            // dataGridViewFunction_MKV
            // 
            dataGridViewFunction_MKV.AllowUserToResizeColumns = false;
            dataGridViewFunction_MKV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_MKV.Columns.AddRange(new DataGridViewColumn[] { X, Columns2 });
            dataGridViewFunction_MKV.Location = new Point(15, 60);
            dataGridViewFunction_MKV.Name = "dataGridViewFunction_MKV";
            dataGridViewFunction_MKV.RowHeadersVisible = false;
            dataGridViewFunction_MKV.RowHeadersWidth = 51;
            dataGridViewFunction_MKV.Size = new Size(159, 375);
            dataGridViewFunction_MKV.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Columns2
            // 
            Columns2.HeaderText = "F(x)";
            Columns2.MinimumWidth = 6;
            Columns2.Name = "Columns2";
            Columns2.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 495);
            Controls.Add(groupBoxResult_MKV);
            Controls.Add(buttonHelp_MKV);
            Controls.Add(buttonDone_MKV);
            Controls.Add(groupBoxOne_MKV);
            Controls.Add(groupBoxTask_MKV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 1 | Мерц К.В";
            groupBoxTask_MKV.ResumeLayout(false);
            groupBoxTask_MKV.PerformLayout();
            groupBoxOne_MKV.ResumeLayout(false);
            groupBoxOne_MKV.PerformLayout();
            groupBoxResult_MKV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_MKV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_MKV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MKV;
        private TextBox textBoxTask_MKV;
        private GroupBox groupBoxOne_MKV;
        private TextBox textBoxOne_MKV;
        private TextBox textBoxStopValue_MKV;
        private TextBox textBoxStartValue_MKV;
        private Button buttonDone_MKV;
        private Button buttonHelp_MKV;
        private GroupBox groupBoxResult_MKV;
        private DataGridView dataGridViewFunction_MKV;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Columns2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MKV;
    }
}
