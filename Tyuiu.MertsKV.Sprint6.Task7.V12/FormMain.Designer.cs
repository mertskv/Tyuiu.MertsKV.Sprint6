namespace Tyuiu.MertsKV.Sprint6.Task7.V12
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_MKV = new Panel();
            panelTwo_MKV = new Panel();
            buttonOpenFile_MKV = new Button();
            buttonDone_MKV = new Button();
            buttonSaveFile_MKV = new Button();
            buttonHelp_MKV = new Button();
            groupBoxTask_MKV = new GroupBox();
            textBoxTask_MKV = new TextBox();
            panelThree_MKV = new Panel();
            panelFour_MKV = new Panel();
            splitter_MKV = new Splitter();
            groupBoxInPut_MKV = new GroupBox();
            groupBoxOutPut_MKV = new GroupBox();
            dataGridViewInPut_MKV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            openFileDialogTask_MKV = new OpenFileDialog();
            toolTipButton_MKV = new ToolTip(components);
            saveFileDialogMatrix_MKV = new SaveFileDialog();
            dataGridViewOutPut_MKV = new DataGridView();
            panelTop_MKV.SuspendLayout();
            panelTwo_MKV.SuspendLayout();
            groupBoxTask_MKV.SuspendLayout();
            panelThree_MKV.SuspendLayout();
            panelFour_MKV.SuspendLayout();
            groupBoxInPut_MKV.SuspendLayout();
            groupBoxOutPut_MKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_MKV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_MKV).BeginInit();
            SuspendLayout();
            // 
            // panelTop_MKV
            // 
            panelTop_MKV.Controls.Add(buttonDone_MKV);
            panelTop_MKV.Controls.Add(buttonSaveFile_MKV);
            panelTop_MKV.Controls.Add(buttonHelp_MKV);
            panelTop_MKV.Controls.Add(buttonOpenFile_MKV);
            panelTop_MKV.Dock = DockStyle.Top;
            panelTop_MKV.Location = new Point(0, 0);
            panelTop_MKV.Name = "panelTop_MKV";
            panelTop_MKV.Size = new Size(1101, 125);
            panelTop_MKV.TabIndex = 0;
            // 
            // panelTwo_MKV
            // 
            panelTwo_MKV.Controls.Add(groupBoxTask_MKV);
            panelTwo_MKV.Dock = DockStyle.Top;
            panelTwo_MKV.Location = new Point(0, 125);
            panelTwo_MKV.Name = "panelTwo_MKV";
            panelTwo_MKV.Size = new Size(1101, 125);
            panelTwo_MKV.TabIndex = 0;
            // 
            // buttonOpenFile_MKV
            // 
            buttonOpenFile_MKV.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_MKV.Image = (Image)resources.GetObject("buttonOpenFile_MKV.Image");
            buttonOpenFile_MKV.Location = new Point(30, 33);
            buttonOpenFile_MKV.Name = "buttonOpenFile_MKV";
            buttonOpenFile_MKV.Size = new Size(122, 67);
            buttonOpenFile_MKV.TabIndex = 0;
            toolTipButton_MKV.SetToolTip(buttonOpenFile_MKV, "Открыть файл для ознакомления");
            buttonOpenFile_MKV.UseVisualStyleBackColor = true;
            buttonOpenFile_MKV.Click += this.buttonOpenFile_MKV_Click;
            buttonOpenFile_MKV.MouseEnter += this.buttonOpenFile_MKV_MouseEnter;
            // 
            // buttonDone_MKV
            // 
            buttonDone_MKV.FlatStyle = FlatStyle.Flat;
            buttonDone_MKV.Image = (Image)resources.GetObject("buttonDone_MKV.Image");
            buttonDone_MKV.Location = new Point(217, 33);
            buttonDone_MKV.Name = "buttonDone_MKV";
            buttonDone_MKV.Size = new Size(117, 67);
            buttonDone_MKV.TabIndex = 0;
            toolTipButton_MKV.SetToolTip(buttonDone_MKV, "Выполнить");
            buttonDone_MKV.UseVisualStyleBackColor = true;
            buttonDone_MKV.Click += this.buttonDone_MKV_Click;
            buttonDone_MKV.MouseEnter += this.buttonDone_MKV_MouseEnter;
            // 
            // buttonSaveFile_MKV
            // 
            buttonSaveFile_MKV.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_MKV.Image = (Image)resources.GetObject("buttonSaveFile_MKV.Image");
            buttonSaveFile_MKV.Location = new Point(386, 33);
            buttonSaveFile_MKV.Name = "buttonSaveFile_MKV";
            buttonSaveFile_MKV.Size = new Size(127, 67);
            buttonSaveFile_MKV.TabIndex = 0;
            toolTipButton_MKV.SetToolTip(buttonSaveFile_MKV, "Открыть новый файл");
            buttonSaveFile_MKV.UseVisualStyleBackColor = true;
            buttonSaveFile_MKV.Click += this.buttonSaveFile_MKV_Click;
            buttonSaveFile_MKV.MouseEnter += this.buttonSaveFile_MKV_MouseEnter;
            // 
            // buttonHelp_MKV
            // 
            buttonHelp_MKV.FlatStyle = FlatStyle.Flat;
            buttonHelp_MKV.Image = (Image)resources.GetObject("buttonHelp_MKV.Image");
            buttonHelp_MKV.Location = new Point(967, 33);
            buttonHelp_MKV.Name = "buttonHelp_MKV";
            buttonHelp_MKV.Size = new Size(116, 67);
            buttonHelp_MKV.TabIndex = 0;
            toolTipButton_MKV.SetToolTip(buttonHelp_MKV, "Справка");
            buttonHelp_MKV.UseVisualStyleBackColor = true;
            buttonHelp_MKV.Click += this.buttonHelp_MKV_Click;
            buttonHelp_MKV.MouseEnter += this.buttonHelp_MKV_MouseEnter;
            // 
            // groupBoxTask_MKV
            // 
            groupBoxTask_MKV.Controls.Add(textBoxTask_MKV);
            groupBoxTask_MKV.Location = new Point(3, 6);
            groupBoxTask_MKV.Name = "groupBoxTask_MKV";
            groupBoxTask_MKV.Size = new Size(1086, 113);
            groupBoxTask_MKV.TabIndex = 1;
            groupBoxTask_MKV.TabStop = false;
            groupBoxTask_MKV.Text = "Условие:";
            // 
            // textBoxTask_MKV
            // 
            textBoxTask_MKV.Location = new Point(3, 23);
            textBoxTask_MKV.Multiline = true;
            textBoxTask_MKV.Name = "textBoxTask_MKV";
            textBoxTask_MKV.ReadOnly = true;
            textBoxTask_MKV.Size = new Size(1077, 84);
            textBoxTask_MKV.TabIndex = 0;
            textBoxTask_MKV.Text = resources.GetString("textBoxTask_MKV.Text");
            // 
            // panelThree_MKV
            // 
            panelThree_MKV.Controls.Add(groupBoxInPut_MKV);
            panelThree_MKV.Dock = DockStyle.Left;
            panelThree_MKV.Location = new Point(0, 250);
            panelThree_MKV.Name = "panelThree_MKV";
            panelThree_MKV.Size = new Size(594, 256);
            panelThree_MKV.TabIndex = 1;
            // 
            // panelFour_MKV
            // 
            panelFour_MKV.Controls.Add(groupBoxOutPut_MKV);
            panelFour_MKV.Controls.Add(splitter_MKV);
            panelFour_MKV.Dock = DockStyle.Right;
            panelFour_MKV.Location = new Point(555, 250);
            panelFour_MKV.Name = "panelFour_MKV";
            panelFour_MKV.Size = new Size(546, 256);
            panelFour_MKV.TabIndex = 1;
            // 
            // splitter_MKV
            // 
            splitter_MKV.Location = new Point(0, 0);
            splitter_MKV.Name = "splitter_MKV";
            splitter_MKV.Size = new Size(4, 256);
            splitter_MKV.TabIndex = 0;
            splitter_MKV.TabStop = false;
            // 
            // groupBoxInPut_MKV
            // 
            groupBoxInPut_MKV.Controls.Add(dataGridViewInPut_MKV);
            groupBoxInPut_MKV.Location = new Point(0, 0);
            groupBoxInPut_MKV.Name = "groupBoxInPut_MKV";
            groupBoxInPut_MKV.Size = new Size(587, 256);
            groupBoxInPut_MKV.TabIndex = 0;
            groupBoxInPut_MKV.TabStop = false;
            groupBoxInPut_MKV.Text = "Ввод:";
            // 
            // groupBoxOutPut_MKV
            // 
            groupBoxOutPut_MKV.Controls.Add(dataGridViewOutPut_MKV);
            groupBoxOutPut_MKV.Location = new Point(10, 6);
            groupBoxOutPut_MKV.Name = "groupBoxOutPut_MKV";
            groupBoxOutPut_MKV.Size = new Size(498, 247);
            groupBoxOutPut_MKV.TabIndex = 0;
            groupBoxOutPut_MKV.TabStop = false;
            groupBoxOutPut_MKV.Text = "Вывод:";
            // 
            // dataGridViewInPut_MKV
            // 
            dataGridViewInPut_MKV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_MKV.ColumnHeadersVisible = false;
            dataGridViewInPut_MKV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridViewInPut_MKV.Location = new Point(3, 20);
            dataGridViewInPut_MKV.Name = "dataGridViewInPut_MKV";
            dataGridViewInPut_MKV.RowHeadersVisible = false;
            dataGridViewInPut_MKV.RowHeadersWidth = 51;
            dataGridViewInPut_MKV.Size = new Size(534, 230);
            dataGridViewInPut_MKV.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            Column4.Width = 50;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            Column5.Width = 50;
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.Name = "Column6";
            Column6.Width = 50;
            // 
            // Column7
            // 
            Column7.HeaderText = "Column7";
            Column7.Name = "Column7";
            Column7.Width = 50;
            // 
            // Column8
            // 
            Column8.HeaderText = "Column8";
            Column8.Name = "Column8";
            Column8.Width = 50;
            // 
            // Column9
            // 
            Column9.HeaderText = "Column9";
            Column9.Name = "Column9";
            Column9.Width = 50;
            // 
            // Column10
            // 
            Column10.HeaderText = "Column10";
            Column10.Name = "Column10";
            Column10.Width = 50;
            // 
            // openFileDialogTask_MKV
            // 
            openFileDialogTask_MKV.FileName = "openFileDialog1";
            // 
            // toolTipButton_MKV
            // 
            toolTipButton_MKV.IsBalloon = true;
            toolTipButton_MKV.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_MKV.ToolTipTitle = "Подсказка";
            // 
            // dataGridViewOutPut_MKV
            // 
            dataGridViewOutPut_MKV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_MKV.Location = new Point(0, 26);
            dataGridViewOutPut_MKV.Name = "dataGridViewOutPut_MKV";
            dataGridViewOutPut_MKV.RowHeadersWidth = 51;
            dataGridViewOutPut_MKV.Size = new Size(518, 224);
            dataGridViewOutPut_MKV.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 506);
            Controls.Add(panelFour_MKV);
            Controls.Add(panelThree_MKV);
            Controls.Add(panelTwo_MKV);
            Controls.Add(panelTop_MKV);
            MinimizeBox = false;
            MinimumSize = new Size(1119, 553);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 12 | Мерц К.В";
            panelTop_MKV.ResumeLayout(false);
            panelTwo_MKV.ResumeLayout(false);
            groupBoxTask_MKV.ResumeLayout(false);
            groupBoxTask_MKV.PerformLayout();
            panelThree_MKV.ResumeLayout(false);
            panelFour_MKV.ResumeLayout(false);
            groupBoxInPut_MKV.ResumeLayout(false);
            groupBoxOutPut_MKV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_MKV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_MKV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_MKV;
        private Panel panelTwo_MKV;
        private Button buttonDone_MKV;
        private Button buttonSaveFile_MKV;
        private Button buttonHelp_MKV;
        private Button buttonOpenFile_MKV;
        private GroupBox groupBoxTask_MKV;
        private TextBox textBoxTask_MKV;
        private Panel panelThree_MKV;
        private Panel panelFour_MKV;
        private Splitter splitter_MKV;
        private GroupBox groupBoxInPut_MKV;
        private DataGridView dataGridViewInPut_MKV;
        private GroupBox groupBoxOutPut_MKV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private OpenFileDialog openFileDialogTask_MKV;
        private ToolTip toolTipButton_MKV;
        private SaveFileDialog saveFileDialogMatrix_MKV;
        private DataGridView dataGridViewOutPut_MKV;
    }
}
