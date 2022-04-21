namespace Generator_Password_Word_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonGeneratePassworsd = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SpecialSimvolRadioButton = new System.Windows.Forms.RadioButton();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxCountNumber = new System.Windows.Forms.ComboBox();
            this.comboBoxLengthPassword = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSpecialSimvol = new System.Windows.Forms.Label();
            this.comboBoxSpecialSimvol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBigLetter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSmallLetter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButtonGeneratePassworsd
            // 
            this.ButtonGeneratePassworsd.Location = new System.Drawing.Point(51, 340);
            this.ButtonGeneratePassworsd.Name = "ButtonGeneratePassworsd";
            this.ButtonGeneratePassworsd.Size = new System.Drawing.Size(235, 42);
            this.ButtonGeneratePassworsd.TabIndex = 0;
            this.ButtonGeneratePassworsd.Text = "Генерировать пароль";
            this.ButtonGeneratePassworsd.UseVisualStyleBackColor = true;
            this.ButtonGeneratePassworsd.Click += new System.EventHandler(this.ButtonGeneratePassworsd_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(407, 340);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(288, 42);
            this.ButtonClear.TabIndex = 1;
            this.ButtonClear.Text = "Сброс";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(764, 340);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(289, 42);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.Text = "Выход";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // SpecialSimvolRadioButton
            // 
            this.SpecialSimvolRadioButton.AutoSize = true;
            this.SpecialSimvolRadioButton.Location = new System.Drawing.Point(620, 117);
            this.SpecialSimvolRadioButton.Name = "SpecialSimvolRadioButton";
            this.SpecialSimvolRadioButton.Size = new System.Drawing.Size(214, 24);
            this.SpecialSimvolRadioButton.TabIndex = 3;
            this.SpecialSimvolRadioButton.Text = "Наличие спецсимволов";
            this.SpecialSimvolRadioButton.UseVisualStyleBackColor = true;
            this.SpecialSimvolRadioButton.Click += new System.EventHandler(this.SpecialSimvolRadioButton_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(76, 254);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(250, 44);
            this.textBoxPassword.TabIndex = 5;
            // 
            // comboBoxCountNumber
            // 
            this.comboBoxCountNumber.FormattingEnabled = true;
            this.comboBoxCountNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.comboBoxCountNumber.Location = new System.Drawing.Point(236, 160);
            this.comboBoxCountNumber.Name = "comboBoxCountNumber";
            this.comboBoxCountNumber.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCountNumber.TabIndex = 6;
            // 
            // comboBoxLengthPassword
            // 
            this.comboBoxLengthPassword.FormattingEnabled = true;
            this.comboBoxLengthPassword.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.comboBoxLengthPassword.Location = new System.Drawing.Point(51, 160);
            this.comboBoxLengthPassword.Name = "comboBoxLengthPassword";
            this.comboBoxLengthPassword.Size = new System.Drawing.Size(121, 28);
            this.comboBoxLengthPassword.TabIndex = 7;
            this.comboBoxLengthPassword.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Длинна пароля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество цифр";
            // 
            // labelSpecialSimvol
            // 
            this.labelSpecialSimvol.AutoSize = true;
            this.labelSpecialSimvol.Location = new System.Drawing.Point(600, 168);
            this.labelSpecialSimvol.Name = "labelSpecialSimvol";
            this.labelSpecialSimvol.Size = new System.Drawing.Size(178, 20);
            this.labelSpecialSimvol.TabIndex = 11;
            this.labelSpecialSimvol.Text = "Количество символов";
            // 
            // comboBoxSpecialSimvol
            // 
            this.comboBoxSpecialSimvol.FormattingEnabled = true;
            this.comboBoxSpecialSimvol.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.comboBoxSpecialSimvol.Location = new System.Drawing.Point(620, 215);
            this.comboBoxSpecialSimvol.Name = "comboBoxSpecialSimvol";
            this.comboBoxSpecialSimvol.Size = new System.Drawing.Size(121, 28);
            this.comboBoxSpecialSimvol.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Количество больших букв";
            // 
            // comboBoxBigLetter
            // 
            this.comboBoxBigLetter.FormattingEnabled = true;
            this.comboBoxBigLetter.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.comboBoxBigLetter.Location = new System.Drawing.Point(407, 160);
            this.comboBoxBigLetter.Name = "comboBoxBigLetter";
            this.comboBoxBigLetter.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBigLetter.TabIndex = 12;
            this.comboBoxBigLetter.Text = "7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "Количество маленьких \r\n              букв";
            // 
            // comboBoxSmallLetter
            // 
            this.comboBoxSmallLetter.FormattingEnabled = true;
            this.comboBoxSmallLetter.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.comboBoxSmallLetter.Location = new System.Drawing.Point(407, 263);
            this.comboBoxSmallLetter.Name = "comboBoxSmallLetter";
            this.comboBoxSmallLetter.Size = new System.Drawing.Size(121, 28);
            this.comboBoxSmallLetter.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1093, 417);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSmallLetter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBigLetter);
            this.Controls.Add(this.labelSpecialSimvol);
            this.Controls.Add(this.comboBoxSpecialSimvol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxLengthPassword);
            this.Controls.Add(this.comboBoxCountNumber);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.SpecialSimvolRadioButton);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonGeneratePassworsd);
            this.Name = "Form1";
            this.Text = "Генератор паролей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonGeneratePassworsd;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.RadioButton SpecialSimvolRadioButton;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxCountNumber;
        private System.Windows.Forms.ComboBox comboBoxLengthPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSpecialSimvol;
        private System.Windows.Forms.ComboBox comboBoxSpecialSimvol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBigLetter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSmallLetter;
    }
}

