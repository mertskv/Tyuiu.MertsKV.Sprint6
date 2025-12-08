
namespace Tyuiu.MertsKV.Sprint6.Task1.V28
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
            groupBoxTask_MKV = new GroupBox();
            textBoxTask_MKV = new TextBox();
            groupBoxOne_MKV = new GroupBox();
            textBoxStopValue_MKV = new TextBox();
            textBoxStartValue_MKV = new TextBox();
            textBoxOne_MKV = new TextBox();
            groupBoxResult_MKV = new GroupBox();
            textBoxResult_MKV = new TextBox();
            buttonDone_MKV = new Button();
            buttonHelp_MKV = new Button();
            groupBoxTask_MKV.SuspendLayout();
            groupBoxOne_MKV.SuspendLayout();
            groupBoxResult_MKV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_MKV
            // 
            groupBoxTask_MKV.Controls.Add(textBoxTask_MKV);
            groupBoxTask_MKV.Location = new Point(0, 0);
            groupBoxTask_MKV.Name = "groupBoxTask_MKV";
            groupBoxTask_MKV.Size = new Size(580, 275);
            groupBoxTask_MKV.TabIndex = 0;
            groupBoxTask_MKV.TabStop = false;
            groupBoxTask_MKV.Text = "Условие:";
            // 
            // textBoxTask_MKV
            // 
            textBoxTask_MKV.Location = new Point(12, 26);
            textBoxTask_MKV.Multiline = true;
            textBoxTask_MKV.Name = "textBoxTask_MKV";
            textBoxTask_MKV.ReadOnly = true;
            textBoxTask_MKV.Size = new Size(447, 207);
            textBoxTask_MKV.TabIndex = 1;
            textBoxTask_MKV.Text = "Протабулировать функцию f(x) на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxOne_MKV
            // 
            groupBoxOne_MKV.Controls.Add(textBoxStopValue_MKV);
            groupBoxOne_MKV.Controls.Add(textBoxStartValue_MKV);
            groupBoxOne_MKV.Controls.Add(textBoxOne_MKV);
            groupBoxOne_MKV.Location = new Point(12, 296);
            groupBoxOne_MKV.Name = "groupBoxOne_MKV";
            groupBoxOne_MKV.Size = new Size(326, 127);
            groupBoxOne_MKV.TabIndex = 1;
            groupBoxOne_MKV.TabStop = false;
            groupBoxOne_MKV.Text = "Ввод данных:";
            // 
            // textBoxStopValue_MKV
            // 
            textBoxStopValue_MKV.Location = new Point(184, 81);
            textBoxStopValue_MKV.Name = "textBoxStopValue_MKV";
            textBoxStopValue_MKV.Size = new Size(125, 27);
            textBoxStopValue_MKV.TabIndex = 2;
            textBoxStopValue_MKV.Text = "5";
            // 
            // textBoxStartValue_MKV
            // 
            textBoxStartValue_MKV.Location = new Point(6, 81);
            textBoxStartValue_MKV.Name = "textBoxStartValue_MKV";
            textBoxStartValue_MKV.Size = new Size(125, 27);
            textBoxStartValue_MKV.TabIndex = 2;
            textBoxStartValue_MKV.Text = "-5";
            // 
            // textBoxOne_MKV
            // 
            textBoxOne_MKV.Location = new Point(0, 26);
            textBoxOne_MKV.Multiline = true;
            textBoxOne_MKV.Name = "textBoxOne_MKV";
            textBoxOne_MKV.ReadOnly = true;
            textBoxOne_MKV.Size = new Size(342, 38);
            textBoxOne_MKV.TabIndex = 2;
            textBoxOne_MKV.Text = "Старт шага:                            Конец шага:";
            // 
            // groupBoxResult_MKV
            // 
            groupBoxResult_MKV.Controls.Add(textBoxResult_MKV);
            groupBoxResult_MKV.Location = new Point(651, 12);
            groupBoxResult_MKV.Name = "groupBoxResult_MKV";
            groupBoxResult_MKV.Size = new Size(341, 452);
            groupBoxResult_MKV.TabIndex = 2;
            groupBoxResult_MKV.TabStop = false;
            groupBoxResult_MKV.Text = "Вывод данных:                                           Результат";
            // 
            // textBoxResult_MKV
            // 
            textBoxResult_MKV.Font = new Font("Consolas", 10F);
            textBoxResult_MKV.Location = new Point(6, 49);
            textBoxResult_MKV.Multiline = true;
            textBoxResult_MKV.Name = "textBoxResult_MKV";
            textBoxResult_MKV.ReadOnly = true;
            textBoxResult_MKV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_MKV.Size = new Size(329, 397);
            textBoxResult_MKV.TabIndex = 3;
            // 
            // buttonDone_MKV
            // 
            buttonDone_MKV.BackColor = Color.Green;
            buttonDone_MKV.Location = new Point(521, 331);
            buttonDone_MKV.Name = "buttonDone_MKV";
            buttonDone_MKV.Size = new Size(104, 79);
            buttonDone_MKV.TabIndex = 3;
            buttonDone_MKV.Text = "Выполнить";
            buttonDone_MKV.UseVisualStyleBackColor = false;
            buttonDone_MKV.Click += buttonDone_MKV_Click;
            // 
            // buttonHelp_MKV
            // 
            buttonHelp_MKV.BackColor = SystemColors.Highlight;
            buttonHelp_MKV.Location = new Point(372, 331);
            buttonHelp_MKV.Name = "buttonHelp_MKV";
            buttonHelp_MKV.Size = new Size(124, 79);
            buttonHelp_MKV.TabIndex = 4;
            buttonHelp_MKV.Text = "Справка";
            buttonHelp_MKV.UseVisualStyleBackColor = false;
            buttonHelp_MKV.Click += buttonHelp_MKV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 476);
            Controls.Add(buttonHelp_MKV);
            Controls.Add(buttonDone_MKV);
            Controls.Add(groupBoxResult_MKV);
            Controls.Add(groupBoxOne_MKV);
            Controls.Add(groupBoxTask_MKV);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 28 | Мерц К.В";
            groupBoxTask_MKV.ResumeLayout(false);
            groupBoxTask_MKV.PerformLayout();
            groupBoxOne_MKV.ResumeLayout(false);
            groupBoxOne_MKV.PerformLayout();
            groupBoxResult_MKV.ResumeLayout(false);
            groupBoxResult_MKV.PerformLayout();
            ResumeLayout(false);
        }

     
        #endregion

        private GroupBox groupBoxTask_MKV;
        private TextBox textBoxTask_MKV;
        private GroupBox groupBoxOne_MKV;
        private TextBox textBoxOne_MKV;
        private TextBox textBoxStopValue_MKV;
        private TextBox textBoxStartValue_MKV;
        private GroupBox groupBoxResult_MKV;
        private TextBox textBoxResult_MKV;
        private Button buttonDone_MKV;
        private Button buttonHelp_MKV;
    }
}
