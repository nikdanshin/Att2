namespace _7._39
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
            this.ArrInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CountOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArrInput
            // 
            this.ArrInput.Location = new System.Drawing.Point(12, 25);
            this.ArrInput.Name = "ArrInput";
            this.ArrInput.Size = new System.Drawing.Size(260, 20);
            this.ArrInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "введите массив";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(30, 63);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(203, 23);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Text = "посчитать элементы между нулями";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "значение:";
            // 
            // CountOutput
            // 
            this.CountOutput.AutoSize = true;
            this.CountOutput.Location = new System.Drawing.Point(73, 102);
            this.CountOutput.Name = "CountOutput";
            this.CountOutput.Size = new System.Drawing.Size(10, 13);
            this.CountOutput.TabIndex = 12;
            this.CountOutput.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CountOutput);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ArrInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "7.39";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ArrInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CountOutput;
    }
}

