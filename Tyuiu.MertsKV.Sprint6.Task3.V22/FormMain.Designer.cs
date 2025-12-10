namespace Tyuiu.MertsKV.Sprint6.Task3.V22
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
            groupBoxResult_MKV = new GroupBox();
            textBoxResult_MKV = new TextBox();
            buttonDone_MKV = new Button();
            buttonHelp_MKV = new Button();
            dataGridViewMatrix_MKV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBoxTask_MKV.SuspendLayout();
            groupBoxResult_MKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_MKV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_MKV
            // 
            groupBoxTask_MKV.Controls.Add(textBoxTask_MKV);
            groupBoxTask_MKV.Location = new Point(0, 0);
            groupBoxTask_MKV.Name = "groupBoxTask_MKV";
            groupBoxTask_MKV.Size = new Size(398, 181);
            groupBoxTask_MKV.TabIndex = 0;
            groupBoxTask_MKV.TabStop = false;
            groupBoxTask_MKV.Text = "Условие";
            // 
            // textBoxTask_MKV
            // 
            textBoxTask_MKV.Location = new Point(12, 26);
            textBoxTask_MKV.Multiline = true;
            textBoxTask_MKV.Name = "textBoxTask_MKV";
            textBoxTask_MKV.ReadOnly = true;
            textBoxTask_MKV.Size = new Size(412, 160);
            textBoxTask_MKV.TabIndex = 1;
            textBoxTask_MKV.Text = "Дана матрица 5 на 5 \r\n17   0  19  -8  -1\r\n 9   4  -5   7  15\r\n11  13   4  -4 -14\r\n11  14   5 -15  16\r\n2 -14  -2  11  11\r\nзаменить четные значения в первой строке на 0.";
            // 
            // groupBoxResult_MKV
            // 
            groupBoxResult_MKV.Controls.Add(textBoxResult_MKV);
            groupBoxResult_MKV.Location = new Point(795, 26);
            groupBoxResult_MKV.Name = "groupBoxResult_MKV";
            groupBoxResult_MKV.Size = new Size(259, 96);
            groupBoxResult_MKV.TabIndex = 1;
            groupBoxResult_MKV.TabStop = false;
            groupBoxResult_MKV.Text = "Вывод данных:                                Результат";
            // 
            // textBoxResult_MKV
            // 
            textBoxResult_MKV.Location = new Point(25, 54);
            textBoxResult_MKV.Name = "textBoxResult_MKV";
            textBoxResult_MKV.ReadOnly = true;
            textBoxResult_MKV.Size = new Size(125, 27);
            textBoxResult_MKV.TabIndex = 2;
            // 
            // buttonDone_MKV
            // 
            buttonDone_MKV.Location = new Point(918, 360);
            buttonDone_MKV.Name = "buttonDone_MKV";
            buttonDone_MKV.Size = new Size(136, 42);
            buttonDone_MKV.TabIndex = 2;
            buttonDone_MKV.Text = "Выполнить";
            buttonDone_MKV.UseVisualStyleBackColor = true;
            buttonDone_MKV.Click += buttonDone_MKV_Click;
            // 
            // buttonHelp_MKV
            // 
            buttonHelp_MKV.Location = new Point(846, 360);
            buttonHelp_MKV.Name = "buttonHelp_MKV";
            buttonHelp_MKV.Size = new Size(53, 42);
            buttonHelp_MKV.TabIndex = 3;
            buttonHelp_MKV.Text = "?";
            buttonHelp_MKV.UseVisualStyleBackColor = true;
            buttonHelp_MKV.Click += buttonHelp_MKV_Click;
            // 
            // dataGridViewMatrix_MKV
            // 
            dataGridViewMatrix_MKV.ColumnHeadersHeight = 29;
            dataGridViewMatrix_MKV.ColumnHeadersVisible = false;
            dataGridViewMatrix_MKV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewMatrix_MKV.Location = new Point(456, 12);
            dataGridViewMatrix_MKV.Name = "dataGridViewMatrix_MKV";
            dataGridViewMatrix_MKV.RowHeadersVisible = false;
            dataGridViewMatrix_MKV.RowHeadersWidth = 51;
            dataGridViewMatrix_MKV.Size = new Size(301, 208);
            dataGridViewMatrix_MKV.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 60;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 60;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 60;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 60;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 60;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 414);
            Controls.Add(dataGridViewMatrix_MKV);
            Controls.Add(buttonHelp_MKV);
            Controls.Add(buttonDone_MKV);
            Controls.Add(groupBoxResult_MKV);
            Controls.Add(groupBoxTask_MKV);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 22 | Мерц К.В";
            Load += FormMain_Load;
            groupBoxTask_MKV.ResumeLayout(false);
            groupBoxTask_MKV.PerformLayout();
            groupBoxResult_MKV.ResumeLayout(false);
            groupBoxResult_MKV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_MKV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MKV;
        private TextBox textBoxTask_MKV;
        private GroupBox groupBoxResult_MKV;
        private TextBox textBoxResult_MKV;
        private Button buttonDone_MKV;
        private Button buttonHelp_MKV;
        private DataGridView dataGridViewMatrix_MKV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
