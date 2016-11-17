namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.T2_button4 = new System.Windows.Forms.Button();
            this.T2_button1 = new System.Windows.Forms.Button();
            this.T2_textBox2 = new System.Windows.Forms.TextBox();
            this.T2_textBox1 = new System.Windows.Forms.TextBox();
            this.T2_textBox3 = new System.Windows.Forms.TextBox();
            this.T2_button6 = new System.Windows.Forms.Button();
            this.T2_button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // T2_button4
            // 
            this.T2_button4.Location = new System.Drawing.Point(343, 143);
            this.T2_button4.Name = "T2_button4";
            this.T2_button4.Size = new System.Drawing.Size(75, 23);
            this.T2_button4.TabIndex = 11;
            this.T2_button4.Text = "Умножение";
            this.T2_button4.UseVisualStyleBackColor = true;
            // 
            // T2_button1
            // 
            this.T2_button1.Location = new System.Drawing.Point(80, 143);
            this.T2_button1.Name = "T2_button1";
            this.T2_button1.Size = new System.Drawing.Size(75, 23);
            this.T2_button1.TabIndex = 10;
            this.T2_button1.Text = "Сложение";
            this.T2_button1.UseVisualStyleBackColor = true;
            // 
            // T2_textBox2
            // 
            this.T2_textBox2.Location = new System.Drawing.Point(309, 62);
            this.T2_textBox2.Name = "T2_textBox2";
            this.T2_textBox2.Size = new System.Drawing.Size(139, 20);
            this.T2_textBox2.TabIndex = 9;
            // 
            // T2_textBox1
            // 
            this.T2_textBox1.Location = new System.Drawing.Point(46, 62);
            this.T2_textBox1.Name = "T2_textBox1";
            this.T2_textBox1.Size = new System.Drawing.Size(141, 20);
            this.T2_textBox1.TabIndex = 8;
            // 
            // T2_textBox3
            // 
            this.T2_textBox3.Location = new System.Drawing.Point(114, 446);
            this.T2_textBox3.Name = "T2_textBox3";
            this.T2_textBox3.Size = new System.Drawing.Size(262, 20);
            this.T2_textBox3.TabIndex = 12;
            // 
            // T2_button6
            // 
            this.T2_button6.Location = new System.Drawing.Point(343, 380);
            this.T2_button6.Name = "T2_button6";
            this.T2_button6.Size = new System.Drawing.Size(75, 23);
            this.T2_button6.TabIndex = 14;
            this.T2_button6.Text = "Корень";
            this.T2_button6.UseVisualStyleBackColor = true;
            this.T2_button6.Click += new System.EventHandler(this.T2_button6_Click);
            // 
            // T2_button3
            // 
            this.T2_button3.Location = new System.Drawing.Point(80, 380);
            this.T2_button3.Name = "T2_button3";
            this.T2_button3.Size = new System.Drawing.Size(75, 22);
            this.T2_button3.TabIndex = 13;
            this.T2_button3.Text = "В степень";
            this.T2_button3.UseVisualStyleBackColor = true;
            this.T2_button3.Click += new System.EventHandler(this.T2_button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 537);
            this.Controls.Add(this.T2_button6);
            this.Controls.Add(this.T2_button3);
            this.Controls.Add(this.T2_textBox3);
            this.Controls.Add(this.T2_button4);
            this.Controls.Add(this.T2_button1);
            this.Controls.Add(this.T2_textBox2);
            this.Controls.Add(this.T2_textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button T2_button4;
        private System.Windows.Forms.Button T2_button1;
        private System.Windows.Forms.TextBox T2_textBox2;
        private System.Windows.Forms.TextBox T2_textBox1;
        private System.Windows.Forms.TextBox T2_textBox3;
        private System.Windows.Forms.Button T2_button6;
        private System.Windows.Forms.Button T2_button3;
    }
}

