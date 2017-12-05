namespace _7._8
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
            this.label1 = new System.Windows.Forms.Label();
            this.ArrInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IndexOutput = new System.Windows.Forms.Label();
            this.ElementOutput = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "введите массив";
            // 
            // ArrInput
            // 
            this.ArrInput.Location = new System.Drawing.Point(16, 29);
            this.ArrInput.Name = "ArrInput";
            this.ArrInput.Size = new System.Drawing.Size(256, 20);
            this.ArrInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "R =";
            // 
            // RInput
            // 
            this.RInput.Location = new System.Drawing.Point(43, 55);
            this.RInput.Name = "RInput";
            this.RInput.Size = new System.Drawing.Size(229, 20);
            this.RInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "индекс:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "значение:";
            // 
            // IndexOutput
            // 
            this.IndexOutput.AutoSize = true;
            this.IndexOutput.Location = new System.Drawing.Point(65, 115);
            this.IndexOutput.Name = "IndexOutput";
            this.IndexOutput.Size = new System.Drawing.Size(10, 13);
            this.IndexOutput.TabIndex = 6;
            this.IndexOutput.Text = " ";
            // 
            // ElementOutput
            // 
            this.ElementOutput.AutoSize = true;
            this.ElementOutput.Location = new System.Drawing.Point(75, 132);
            this.ElementOutput.Name = "ElementOutput";
            this.ElementOutput.Size = new System.Drawing.Size(10, 13);
            this.ElementOutput.TabIndex = 7;
            this.ElementOutput.Text = " ";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(68, 81);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(152, 23);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "найти ближайший элемент";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ElementOutput);
            this.Controls.Add(this.IndexOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArrInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "7.8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ArrInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IndexOutput;
        private System.Windows.Forms.Label ElementOutput;
        private System.Windows.Forms.Button SearchBtn;
    }
}

