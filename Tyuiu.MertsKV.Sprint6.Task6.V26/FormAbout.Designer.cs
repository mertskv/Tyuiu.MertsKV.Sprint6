namespace Tyuiu.MertsKV.Sprint6.Task6.V26
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
            textBoxAbout_MKV = new TextBox();
            buttonOK_MKV = new Button();
            pictureBoxAbout_MKV = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_MKV).BeginInit();
            SuspendLayout();
            // 
            // textBoxAbout_MKV
            // 
            textBoxAbout_MKV.Location = new Point(264, 0);
            textBoxAbout_MKV.Multiline = true;
            textBoxAbout_MKV.Name = "textBoxAbout_MKV";
            textBoxAbout_MKV.ReadOnly = true;
            textBoxAbout_MKV.Size = new Size(466, 318);
            textBoxAbout_MKV.TabIndex = 0;
            textBoxAbout_MKV.Text = "Разработчик: Мерц К.В\r\nГруппа: ИСТНб-25-1\r\n\r\nПрограмма разработана в рамках изучения языка C#\r\n\r\nТИУ 2025\r\nВЩЦТ 2025\r\n\r\nВнутреннее имя: Tyuiu.MertsKV.Sprint6.Task6.V26";
            // 
            // buttonOK_MKV
            // 
            buttonOK_MKV.Location = new Point(620, 366);
            buttonOK_MKV.Name = "buttonOK_MKV";
            buttonOK_MKV.Size = new Size(94, 29);
            buttonOK_MKV.TabIndex = 1;
            buttonOK_MKV.Text = "Ок";
            buttonOK_MKV.UseVisualStyleBackColor = true;
            // 
            // pictureBoxAbout_MKV
            // 
            pictureBoxAbout_MKV.Image = (Image)resources.GetObject("pictureBoxAbout_MKV.Image");
            pictureBoxAbout_MKV.Location = new Point(12, 12);
            pictureBoxAbout_MKV.Name = "pictureBoxAbout_MKV";
            pictureBoxAbout_MKV.Size = new Size(232, 284);
            pictureBoxAbout_MKV.TabIndex = 2;
            pictureBoxAbout_MKV.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxAbout_MKV);
            Controls.Add(buttonOK_MKV);
            Controls.Add(textBoxAbout_MKV);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_MKV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAbout_MKV;
        private Button buttonOK_MKV;
        private PictureBox pictureBoxAbout_MKV;
    }
}