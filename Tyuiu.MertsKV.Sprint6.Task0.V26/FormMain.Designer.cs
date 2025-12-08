namespace Tyuiu.MertsKV.Sprint6.Task0.V26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_MKV = new GroupBox();
            pictureBoxFormula_MKV = new PictureBox();
            textBoxTask_MKV = new TextBox();
            groupBoxOne_MKV = new GroupBox();
            textBoxVarX_MKV = new TextBox();
            textBoxOne_MKV = new TextBox();
            groupBoxTwo_MKV = new GroupBox();
            textBoxResult_MKV = new TextBox();
            textBoxTwo_MKV = new TextBox();
            buttonDone_MKV = new Button();
            buttonHelp_MKV = new Button();
            groupBoxTask_MKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_MKV).BeginInit();
            groupBoxOne_MKV.SuspendLayout();
            groupBoxTwo_MKV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_MKV
            // 
            groupBoxTask_MKV.Controls.Add(pictureBoxFormula_MKV);
            groupBoxTask_MKV.Controls.Add(textBoxTask_MKV);
            groupBoxTask_MKV.Location = new Point(0, 12);
            groupBoxTask_MKV.Name = "groupBoxTask_MKV";
            groupBoxTask_MKV.Size = new Size(788, 229);
            groupBoxTask_MKV.TabIndex = 0;
            groupBoxTask_MKV.TabStop = false;
            groupBoxTask_MKV.Text = "Условие";
            // 
            // pictureBoxFormula_MKV
            // 
            pictureBoxFormula_MKV.Image = (Image)resources.GetObject("pictureBoxFormula_MKV.Image");
            pictureBoxFormula_MKV.Location = new Point(542, 78);
            pictureBoxFormula_MKV.Name = "pictureBoxFormula_MKV";
            pictureBoxFormula_MKV.Size = new Size(172, 75);
            pictureBoxFormula_MKV.TabIndex = 1;
            pictureBoxFormula_MKV.TabStop = false;
            // 
            // textBoxTask_MKV
            // 
            textBoxTask_MKV.Location = new Point(3, 23);
            textBoxTask_MKV.Multiline = true;
            textBoxTask_MKV.Name = "textBoxTask_MKV";
            textBoxTask_MKV.ReadOnly = true;
            textBoxTask_MKV.Size = new Size(436, 199);
            textBoxTask_MKV.TabIndex = 0;
            textBoxTask_MKV.Text = "Вычислить выражение по формуле ";
            // 
            // groupBoxOne_MKV
            // 
            groupBoxOne_MKV.Controls.Add(textBoxVarX_MKV);
            groupBoxOne_MKV.Controls.Add(textBoxOne_MKV);
            groupBoxOne_MKV.Location = new Point(12, 247);
            groupBoxOne_MKV.Name = "groupBoxOne_MKV";
            groupBoxOne_MKV.Size = new Size(250, 109);
            groupBoxOne_MKV.TabIndex = 1;
            groupBoxOne_MKV.TabStop = false;
            groupBoxOne_MKV.Text = "Ввод данных:";
            // 
            // textBoxVarX_MKV
            // 
            textBoxVarX_MKV.Location = new Point(56, 73);
            textBoxVarX_MKV.Name = "textBoxVarX_MKV";
            textBoxVarX_MKV.Size = new Size(125, 27);
            textBoxVarX_MKV.TabIndex = 2;
            textBoxVarX_MKV.KeyPress += textBoxVarX_MKV_KeyPress;
            // 
            // textBoxOne_MKV
            // 
            textBoxOne_MKV.Location = new Point(6, 26);
            textBoxOne_MKV.Name = "textBoxOne_MKV";
            textBoxOne_MKV.ReadOnly = true;
            textBoxOne_MKV.Size = new Size(175, 27);
            textBoxOne_MKV.TabIndex = 2;
            textBoxOne_MKV.Text = "Переменная X:";
            // 
            // groupBoxTwo_MKV
            // 
            groupBoxTwo_MKV.Controls.Add(textBoxResult_MKV);
            groupBoxTwo_MKV.Controls.Add(textBoxTwo_MKV);
            groupBoxTwo_MKV.Location = new Point(470, 247);
            groupBoxTwo_MKV.Name = "groupBoxTwo_MKV";
            groupBoxTwo_MKV.Size = new Size(244, 109);
            groupBoxTwo_MKV.TabIndex = 2;
            groupBoxTwo_MKV.TabStop = false;
            groupBoxTwo_MKV.Text = "Вывод данных:";
            // 
            // textBoxResult_MKV
            // 
            textBoxResult_MKV.Location = new Point(58, 73);
            textBoxResult_MKV.Name = "textBoxResult_MKV";
            textBoxResult_MKV.ReadOnly = true;
            textBoxResult_MKV.Size = new Size(125, 27);
            textBoxResult_MKV.TabIndex = 3;
            // 
            // textBoxTwo_MKV
            // 
            textBoxTwo_MKV.Location = new Point(6, 26);
            textBoxTwo_MKV.Name = "textBoxTwo_MKV";
            textBoxTwo_MKV.ReadOnly = true;
            textBoxTwo_MKV.Size = new Size(196, 27);
            textBoxTwo_MKV.TabIndex = 0;
            textBoxTwo_MKV.Text = "Результат:";
            // 
            // buttonDone_MKV
            // 
            buttonDone_MKV.Location = new Point(560, 384);
            buttonDone_MKV.Name = "buttonDone_MKV";
            buttonDone_MKV.Size = new Size(154, 39);
            buttonDone_MKV.TabIndex = 3;
            buttonDone_MKV.Text = "Выполнить";
            buttonDone_MKV.UseVisualStyleBackColor = true;
            buttonDone_MKV.Click += buttonDone_MKV_Click;
            // 
            // buttonHelp_MKV
            // 
            buttonHelp_MKV.Location = new Point(470, 384);
            buttonHelp_MKV.Name = "buttonHelp_MKV";
            buttonHelp_MKV.Size = new Size(45, 39);
            buttonHelp_MKV.TabIndex = 4;
            buttonHelp_MKV.Text = "?";
            buttonHelp_MKV.UseVisualStyleBackColor = true;
            buttonHelp_MKV.Click += buttonHelp_MKV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 463);
            Controls.Add(buttonHelp_MKV);
            Controls.Add(buttonDone_MKV);
            Controls.Add(groupBoxTwo_MKV);
            Controls.Add(groupBoxOne_MKV);
            Controls.Add(groupBoxTask_MKV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 26 | Мерц К.В";
            groupBoxTask_MKV.ResumeLayout(false);
            groupBoxTask_MKV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_MKV).EndInit();
            groupBoxOne_MKV.ResumeLayout(false);
            groupBoxOne_MKV.PerformLayout();
            groupBoxTwo_MKV.ResumeLayout(false);
            groupBoxTwo_MKV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MKV;
        private TextBox textBoxTask_MKV;
        private PictureBox pictureBoxFormula_MKV;
        private GroupBox groupBoxOne_MKV;
        private TextBox textBoxVarX_MKV;
        private TextBox textBoxOne_MKV;
        private GroupBox groupBoxTwo_MKV;
        private TextBox textBoxResult_MKV;
        private TextBox textBoxTwo_MKV;
        private Button buttonDone_MKV;
        private Button buttonHelp_MKV;
    }
}
