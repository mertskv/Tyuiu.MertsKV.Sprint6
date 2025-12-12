namespace Tyuiu.MertsKV.Sprint6.Task7.V12
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAbout_MKV = new PictureBox();
            textBoxAbout_MKV = new TextBox();
            buttonOk_MKV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_MKV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAbout_MKV
            // 
            pictureBoxAbout_MKV.Image = (Image)resources.GetObject("pictureBoxAbout_MKV.Image");
            pictureBoxAbout_MKV.Location = new Point(0, 0);
            pictureBoxAbout_MKV.Name = "pictureBoxAbout_MKV";
            pictureBoxAbout_MKV.Size = new Size(229, 282);
            pictureBoxAbout_MKV.TabIndex = 0;
            pictureBoxAbout_MKV.TabStop = false;
            // 
            // textBoxAbout_MKV
            // 
            textBoxAbout_MKV.Location = new Point(298, 39);
            textBoxAbout_MKV.Multiline = true;
            textBoxAbout_MKV.Name = "textBoxAbout_MKV";
            textBoxAbout_MKV.ReadOnly = true;
            textBoxAbout_MKV.Size = new Size(402, 313);
            textBoxAbout_MKV.TabIndex = 1;
            textBoxAbout_MKV.Text = "Разработчик: Мерц Кристина Викторовна\r\nГруппа: ИСТНб-25-1\r\n\r\nПрограмма разработана в рамках изучения языка C# \r\n\r\nТИУ 2025\r\nВШЦТ 2025\r\n\r\nВнутренне имя: Tyuiu.MertsKV.Sprint6.Task7.V12";
            // 
            // buttonOk_MKV
            // 
            buttonOk_MKV.Location = new Point(564, 384);
            buttonOk_MKV.Name = "buttonOk_MKV";
            buttonOk_MKV.Size = new Size(94, 29);
            buttonOk_MKV.TabIndex = 2;
            buttonOk_MKV.Text = "Ок";
            buttonOk_MKV.UseVisualStyleBackColor = true;
            buttonOk_MKV.Click += buttonOk_MKV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 456);
            Controls.Add(buttonOk_MKV);
            Controls.Add(textBoxAbout_MKV);
            Controls.Add(pictureBoxAbout_MKV);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_MKV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAbout_MKV;
        private TextBox textBoxAbout_MKV;
        private Button buttonOk_MKV;
    }
}