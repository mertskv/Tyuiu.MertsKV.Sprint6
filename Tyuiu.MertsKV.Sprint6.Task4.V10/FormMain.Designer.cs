namespace Tyuiu.MertsKV.Sprint6.Task4.V10
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelOne_MKV = new Panel();
            panelTwo_MKV = new Panel();
            panelThree_MKV = new Panel();
            splitter_MKV = new Splitter();
            groupBoxTask_MKV = new GroupBox();
            textBoxTask_MKV = new TextBox();
            groupBoxTaskTwo_MKV = new GroupBox();
            textBoxTaskTwo_MKV = new TextBox();
            textBoxStart_MKV = new TextBox();
            textBoxStop_MKV = new TextBox();
            buttonHelp_MKV = new Button();
            buttonSave_MKV = new Button();
            buttonDone_MKV = new Button();
            groupBoxResult_MKV = new GroupBox();
            textBoxResult_MKV = new TextBox();
            chartFunction_MKV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTwo_MKV.SuspendLayout();
            panelThree_MKV.SuspendLayout();
            groupBoxTask_MKV.SuspendLayout();
            groupBoxTaskTwo_MKV.SuspendLayout();
            groupBoxResult_MKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MKV).BeginInit();
            SuspendLayout();
            // 
            // panelOne_MKV
            // 
            panelOne_MKV.BackColor = SystemColors.ControlDark;
            panelOne_MKV.Dock = DockStyle.Top;
            panelOne_MKV.Location = new Point(0, 0);
            panelOne_MKV.Name = "panelOne_MKV";
            panelOne_MKV.Size = new Size(1083, 125);
            panelOne_MKV.TabIndex = 0;
            // 
            // panelTwo_MKV
            // 
            panelTwo_MKV.BackColor = SystemColors.ActiveCaption;
            panelTwo_MKV.Controls.Add(groupBoxResult_MKV);
            panelTwo_MKV.Dock = DockStyle.Left;
            panelTwo_MKV.Location = new Point(0, 125);
            panelTwo_MKV.Name = "panelTwo_MKV";
            panelTwo_MKV.Size = new Size(268, 410);
            panelTwo_MKV.TabIndex = 0;
            // 
            // panelThree_MKV
            // 
            panelThree_MKV.BackColor = SystemColors.Info;
            panelThree_MKV.Controls.Add(chartFunction_MKV);
            panelThree_MKV.Dock = DockStyle.Fill;
            panelThree_MKV.Location = new Point(268, 125);
            panelThree_MKV.Name = "panelThree_MKV";
            panelThree_MKV.Size = new Size(815, 410);
            panelThree_MKV.TabIndex = 0;
            // 
            // splitter_MKV
            // 
            splitter_MKV.Location = new Point(268, 125);
            splitter_MKV.Name = "splitter_MKV";
            splitter_MKV.Size = new Size(4, 410);
            splitter_MKV.TabIndex = 1;
            splitter_MKV.TabStop = false;
            // 
            // groupBoxTask_MKV
            // 
            groupBoxTask_MKV.Controls.Add(buttonDone_MKV);
            groupBoxTask_MKV.Controls.Add(buttonSave_MKV);
            groupBoxTask_MKV.Controls.Add(buttonHelp_MKV);
            groupBoxTask_MKV.Controls.Add(groupBoxTaskTwo_MKV);
            groupBoxTask_MKV.Controls.Add(textBoxTask_MKV);
            groupBoxTask_MKV.Location = new Point(0, 0);
            groupBoxTask_MKV.Name = "groupBoxTask_MKV";
            groupBoxTask_MKV.Size = new Size(1080, 122);
            groupBoxTask_MKV.TabIndex = 2;
            groupBoxTask_MKV.TabStop = false;
            groupBoxTask_MKV.Text = "Условие";
            // 
            // textBoxTask_MKV
            // 
            textBoxTask_MKV.Location = new Point(3, 23);
            textBoxTask_MKV.Multiline = true;
            textBoxTask_MKV.Name = "textBoxTask_MKV";
            textBoxTask_MKV.ReadOnly = true;
            textBoxTask_MKV.Size = new Size(469, 96);
            textBoxTask_MKV.TabIndex = 0;
            textBoxTask_MKV.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox, построить график ф-ии и сохранить файл.\r\nOutPutFileTask.txt по нажатию кнопки.";
            // 
            // groupBoxTaskTwo_MKV
            // 
            groupBoxTaskTwo_MKV.Controls.Add(textBoxStop_MKV);
            groupBoxTaskTwo_MKV.Controls.Add(textBoxStart_MKV);
            groupBoxTaskTwo_MKV.Controls.Add(textBoxTaskTwo_MKV);
            groupBoxTaskTwo_MKV.Location = new Point(478, 23);
            groupBoxTaskTwo_MKV.Name = "groupBoxTaskTwo_MKV";
            groupBoxTaskTwo_MKV.Size = new Size(243, 93);
            groupBoxTaskTwo_MKV.TabIndex = 1;
            groupBoxTaskTwo_MKV.TabStop = false;
            groupBoxTaskTwo_MKV.Text = "Ввод данных:";
            // 
            // textBoxTaskTwo_MKV
            // 
            textBoxTaskTwo_MKV.Location = new Point(3, 23);
            textBoxTaskTwo_MKV.Name = "textBoxTaskTwo_MKV";
            textBoxTaskTwo_MKV.ReadOnly = true;
            textBoxTaskTwo_MKV.Size = new Size(234, 27);
            textBoxTaskTwo_MKV.TabIndex = 0;
            textBoxTaskTwo_MKV.Text = "Старт шага:         Конец шага:";
            // 
            // textBoxStart_MKV
            // 
            textBoxStart_MKV.Location = new Point(6, 56);
            textBoxStart_MKV.Name = "textBoxStart_MKV";
            textBoxStart_MKV.Size = new Size(93, 27);
            textBoxStart_MKV.TabIndex = 1;
            textBoxStart_MKV.Text = "-5";
            // 
            // textBoxStop_MKV
            // 
            textBoxStop_MKV.Location = new Point(132, 56);
            textBoxStop_MKV.Name = "textBoxStop_MKV";
            textBoxStop_MKV.Size = new Size(95, 27);
            textBoxStop_MKV.TabIndex = 2;
            textBoxStop_MKV.Text = "5";
            // 
            // buttonHelp_MKV
            // 
            buttonHelp_MKV.BackColor = Color.Teal;
            buttonHelp_MKV.Location = new Point(968, 29);
            buttonHelp_MKV.Name = "buttonHelp_MKV";
            buttonHelp_MKV.Size = new Size(106, 60);
            buttonHelp_MKV.TabIndex = 2;
            buttonHelp_MKV.Text = "Справка";
            buttonHelp_MKV.UseVisualStyleBackColor = false;
            buttonHelp_MKV.Click += this.buttonHelp_MKV_Click;
            // 
            // buttonSave_MKV
            // 
            buttonSave_MKV.BackColor = Color.RoyalBlue;
            buttonSave_MKV.Location = new Point(853, 29);
            buttonSave_MKV.Name = "buttonSave_MKV";
            buttonSave_MKV.Size = new Size(105, 60);
            buttonSave_MKV.TabIndex = 3;
            buttonSave_MKV.Text = "Сохранить";
            buttonSave_MKV.UseVisualStyleBackColor = false;
            buttonSave_MKV.Click += this.buttonSave_MKV_Click;
            // 
            // buttonDone_MKV
            // 
            buttonDone_MKV.BackColor = Color.Green;
            buttonDone_MKV.Location = new Point(727, 29);
            buttonDone_MKV.Name = "buttonDone_MKV";
            buttonDone_MKV.Size = new Size(120, 60);
            buttonDone_MKV.TabIndex = 4;
            buttonDone_MKV.Text = "Выполнить";
            buttonDone_MKV.UseVisualStyleBackColor = false;
            buttonDone_MKV.Click += this.buttonDone_MKV_Click;
            // 
            // groupBoxResult_MKV
            // 
            groupBoxResult_MKV.Controls.Add(textBoxResult_MKV);
            groupBoxResult_MKV.Location = new Point(3, 6);
            groupBoxResult_MKV.Name = "groupBoxResult_MKV";
            groupBoxResult_MKV.Size = new Size(259, 392);
            groupBoxResult_MKV.TabIndex = 0;
            groupBoxResult_MKV.TabStop = false;
            groupBoxResult_MKV.Text = "Вывод данных:";
            // 
            // textBoxResult_MKV
            // 
            textBoxResult_MKV.Dock = DockStyle.Fill;
            textBoxResult_MKV.Location = new Point(3, 23);
            textBoxResult_MKV.Multiline = true;
            textBoxResult_MKV.Name = "textBoxResult_MKV";
            textBoxResult_MKV.ReadOnly = true;
            textBoxResult_MKV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_MKV.Size = new Size(253, 366);
            textBoxResult_MKV.TabIndex = 0;
            // 
            // chartFunction_MKV
            // 
            chartArea4.Name = "ChartArea1";
            chartFunction_MKV.ChartAreas.Add(chartArea4);
            chartFunction_MKV.Dock = DockStyle.Fill;
            legend4.Name = "Legend1";
            chartFunction_MKV.Legends.Add(legend4);
            chartFunction_MKV.Location = new Point(0, 0);
            chartFunction_MKV.Name = "chartFunction_MKV";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartFunction_MKV.Series.Add(series4);
            chartFunction_MKV.Size = new Size(815, 410);
            chartFunction_MKV.TabIndex = 0;
            chartFunction_MKV.Text = "chartFunction";
            title4.Name = "График функции";
            title4.Text = "График функции";
            chartFunction_MKV.Titles.Add(title4);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 535);
            Controls.Add(groupBoxTask_MKV);
            Controls.Add(splitter_MKV);
            Controls.Add(panelThree_MKV);
            Controls.Add(panelTwo_MKV);
            Controls.Add(panelOne_MKV);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 10 | Мерц К.В";
            panelTwo_MKV.ResumeLayout(false);
            panelThree_MKV.ResumeLayout(false);
            groupBoxTask_MKV.ResumeLayout(false);
            groupBoxTask_MKV.PerformLayout();
            groupBoxTaskTwo_MKV.ResumeLayout(false);
            groupBoxTaskTwo_MKV.PerformLayout();
            groupBoxResult_MKV.ResumeLayout(false);
            groupBoxResult_MKV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MKV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOne_MKV;
        private Panel panelTwo_MKV;
        private Panel panelThree_MKV;
        private Splitter splitter_MKV;
        private GroupBox groupBoxTask_MKV;
        private TextBox textBoxTask_MKV;
        private Button buttonHelp_MKV;
        private GroupBox groupBoxTaskTwo_MKV;
        private TextBox textBoxStop_MKV;
        private TextBox textBoxStart_MKV;
        private TextBox textBoxTaskTwo_MKV;
        private Button buttonDone_MKV;
        private Button buttonSave_MKV;
        private GroupBox groupBoxResult_MKV;
        private TextBox textBoxResult_MKV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MKV;
    }
}
