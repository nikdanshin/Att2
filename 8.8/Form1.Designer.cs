namespace _8._8
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
            this.label2 = new System.Windows.Forms.Label();
            this.ListInput = new System.Windows.Forms.TextBox();
            this.IntInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "введите список гирь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "введите требуемый вес";
            // 
            // ListInput
            // 
            this.ListInput.Location = new System.Drawing.Point(12, 25);
            this.ListInput.Name = "ListInput";
            this.ListInput.Size = new System.Drawing.Size(336, 20);
            this.ListInput.TabIndex = 2;
            // 
            // IntInput
            // 
            this.IntInput.Location = new System.Drawing.Point(146, 51);
            this.IntInput.Name = "IntInput";
            this.IntInput.Size = new System.Drawing.Size(202, 20);
            this.IntInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "найденные комбинации";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(12, 128);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(10, 13);
            this.Output.TabIndex = 5;
            this.Output.Text = " ";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(121, 77);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(136, 23);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "найти комбинации";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 408);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IntInput);
            this.Controls.Add(this.ListInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "8.8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ListInput;
        private System.Windows.Forms.TextBox IntInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button SearchBtn;
    }
}

