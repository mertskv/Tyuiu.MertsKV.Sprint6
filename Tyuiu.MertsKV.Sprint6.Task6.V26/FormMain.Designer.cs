

namespace Tyuiu.MertsKV.Sprint6.Task6.V26
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
            panel1 = new Panel();
            buttonOpenFile_MKV = new Button();
            buttonHelp_MKV = new Button();
            buttonDone_MKV = new Button();
            panel2 = new Panel();
            groupBoxInPutDataFile_MKV = new GroupBox();
            textBoxIn_MKV = new TextBox();
            panel3 = new Panel();
            groupBoxTask_MKV = new GroupBox();
            textBoxTask_MKV = new TextBox();
            panel4 = new Panel();
            groupBoxOutPutDataFileTask_MKV = new GroupBox();
            textBoxOut_MKV = new TextBox();
            openFileDialogTask_MKV = new OpenFileDialog();
            toolTipTask_MKV = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxInPutDataFile_MKV.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxTask_MKV.SuspendLayout();
            panel4.SuspendLayout();
            groupBoxOutPutDataFileTask_MKV.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonOpenFile_MKV);
            panel1.Controls.Add(buttonHelp_MKV);
            panel1.Controls.Add(buttonDone_MKV);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 116);
            panel1.TabIndex = 0;
            // 
            // buttonOpenFile_MKV
            // 
            buttonOpenFile_MKV.Image = (Image)resources.GetObject("buttonOpenFile_MKV.Image");
            buttonOpenFile_MKV.Location = new Point(33, 21);
            buttonOpenFile_MKV.Name = "buttonOpenFile_MKV";
            buttonOpenFile_MKV.Size = new Size(112, 79);
            buttonOpenFile_MKV.TabIndex = 1;
            toolTipTask_MKV.SetToolTip(buttonOpenFile_MKV, "Откройте файлВыберете нужный файл");
            buttonOpenFile_MKV.UseVisualStyleBackColor = true;
            buttonOpenFile_MKV.Click += buttonOpenFile_MKV_Click;
            // 
            // buttonHelp_MKV
            // 
            buttonHelp_MKV.Image = (Image)resources.GetObject("buttonHelp_MKV.Image");
            buttonHelp_MKV.Location = new Point(874, 25);
            buttonHelp_MKV.Name = "buttonHelp_MKV";
            buttonHelp_MKV.Size = new Size(106, 75);
            buttonHelp_MKV.TabIndex = 1;
            toolTipTask_MKV.SetToolTip(buttonHelp_MKV, "Сведения о программе");
            buttonHelp_MKV.UseVisualStyleBackColor = true;
            buttonHelp_MKV.Click += buttonHelp_MKV_Click;
            // 
            // buttonDone_MKV
            // 
            buttonDone_MKV.Image = (Image)resources.GetObject("buttonDone_MKV.Image");
            buttonDone_MKV.Location = new Point(204, 25);
            buttonDone_MKV.Name = "buttonDone_MKV";
            buttonDone_MKV.Size = new Size(125, 75);
            buttonDone_MKV.TabIndex = 1;
            toolTipTask_MKV.SetToolTip(buttonDone_MKV, "Итоговый файл");
            buttonDone_MKV.UseVisualStyleBackColor = true;
            buttonDone_MKV.Click += buttonDone_MKV_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(groupBoxInPutDataFile_MKV);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 332);
            panel2.TabIndex = 0;
            // 
            // groupBoxInPutDataFile_MKV
            // 
            groupBoxInPutDataFile_MKV.Controls.Add(textBoxIn_MKV);
            groupBoxInPutDataFile_MKV.Location = new Point(0, 0);
            groupBoxInPutDataFile_MKV.Name = "groupBoxInPutDataFile_MKV";
            groupBoxInPutDataFile_MKV.Size = new Size(444, 331);
            groupBoxInPutDataFile_MKV.TabIndex = 0;
            groupBoxInPutDataFile_MKV.TabStop = false;
            groupBoxInPutDataFile_MKV.Text = "Ввод: C:\\DataSprint6\\InPutDataFileTask6V26.txt";
            // 
            // textBoxIn_MKV
            // 
            textBoxIn_MKV.Location = new Point(3, 23);
            textBoxIn_MKV.Multiline = true;
            textBoxIn_MKV.Name = "textBoxIn_MKV";
            textBoxIn_MKV.ReadOnly = true;
            textBoxIn_MKV.Size = new Size(435, 302);
            textBoxIn_MKV.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxTask_MKV);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(1010, 134);
            panel3.TabIndex = 0;
            // 
            // groupBoxTask_MKV
            // 
            groupBoxTask_MKV.Controls.Add(textBoxTask_MKV);
            groupBoxTask_MKV.Location = new Point(0, 0);
            groupBoxTask_MKV.Name = "groupBoxTask_MKV";
            groupBoxTask_MKV.Size = new Size(1007, 134);
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
            textBoxTask_MKV.Size = new Size(1004, 111);
            textBoxTask_MKV.TabIndex = 0;
            textBoxTask_MKV.Text = resources.GetString("textBoxTask_MKV.Text");
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxOutPutDataFileTask_MKV);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(544, 250);
            panel4.Name = "panel4";
            panel4.Size = new Size(466, 332);
            panel4.TabIndex = 0;
            // 
            // groupBoxOutPutDataFileTask_MKV
            // 
            groupBoxOutPutDataFileTask_MKV.Controls.Add(textBoxOut_MKV);
            groupBoxOutPutDataFileTask_MKV.Location = new Point(0, 0);
            groupBoxOutPutDataFileTask_MKV.Name = "groupBoxOutPutDataFileTask_MKV";
            groupBoxOutPutDataFileTask_MKV.Size = new Size(463, 332);
            groupBoxOutPutDataFileTask_MKV.TabIndex = 0;
            groupBoxOutPutDataFileTask_MKV.TabStop = false;
            groupBoxOutPutDataFileTask_MKV.Text = "Вывод:";
            // 
            // textBoxOut_MKV
            // 
            textBoxOut_MKV.Location = new Point(3, 23);
            textBoxOut_MKV.Multiline = true;
            textBoxOut_MKV.Name = "textBoxOut_MKV";
            textBoxOut_MKV.ReadOnly = true;
            textBoxOut_MKV.Size = new Size(451, 297);
            textBoxOut_MKV.TabIndex = 0;
            // 
            // openFileDialogTask_MKV
            // 
            openFileDialogTask_MKV.FileName = "openFileDialog1";
            // 
            // toolTipTask_MKV
            // 
            toolTipTask_MKV.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 582);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MaximumSize = new Size(1028, 629);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FormMain";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 26 | Мерц К.В";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxInPutDataFile_MKV.ResumeLayout(false);
            groupBoxInPutDataFile_MKV.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxTask_MKV.ResumeLayout(false);
            groupBoxTask_MKV.PerformLayout();
            panel4.ResumeLayout(false);
            groupBoxOutPutDataFileTask_MKV.ResumeLayout(false);
            groupBoxOutPutDataFileTask_MKV.PerformLayout();
            ResumeLayout(false);
        }

        private void buttonHelp_MKV_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button buttonHelp_MKV;
        private Button buttonDone_MKV;
        private Button buttonOpenFile_MKV;
        private GroupBox groupBoxInPutDataFile_MKV;
        private GroupBox groupBoxTask_MKV;
        private TextBox textBoxTask_MKV;
        private GroupBox groupBoxOutPutDataFileTask_MKV;
        private OpenFileDialog openFileDialogTask_MKV;
        private ToolTip toolTipTask_MKV;
        private TextBox textBoxIn_MKV;
        private TextBox textBoxOut_MKV;
    }
}
