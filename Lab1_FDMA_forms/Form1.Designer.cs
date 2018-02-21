namespace Lab1_FDMA_forms
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxWireLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelAlpha1 = new System.Windows.Forms.Label();
            this.labelAlpha2 = new System.Windows.Forms.Label();
            this.labelAlpha3 = new System.Windows.Forms.Label();
            this.labelAlpha4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(153, 152);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxWireLength
            // 
            this.textBoxWireLength.Location = new System.Drawing.Point(251, 12);
            this.textBoxWireLength.Name = "textBoxWireLength";
            this.textBoxWireLength.Size = new System.Drawing.Size(141, 20);
            this.textBoxWireLength.TabIndex = 1;
            this.textBoxWireLength.Text = "84";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Довжина лінії";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "1,7";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "1,75";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(251, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "1,55";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(251, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 20);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "1,52";
            // 
            // labelAlpha1
            // 
            this.labelAlpha1.AutoSize = true;
            this.labelAlpha1.Location = new System.Drawing.Point(12, 41);
            this.labelAlpha1.Name = "labelAlpha1";
            this.labelAlpha1.Size = new System.Drawing.Size(120, 13);
            this.labelAlpha1.TabIndex = 15;
            this.labelAlpha1.Text = "Kоефіцієнт згасання 1";
            // 
            // labelAlpha2
            // 
            this.labelAlpha2.AutoSize = true;
            this.labelAlpha2.Location = new System.Drawing.Point(12, 67);
            this.labelAlpha2.Name = "labelAlpha2";
            this.labelAlpha2.Size = new System.Drawing.Size(120, 13);
            this.labelAlpha2.TabIndex = 16;
            this.labelAlpha2.Text = "Kоефіцієнт згасання 2";
            // 
            // labelAlpha3
            // 
            this.labelAlpha3.AutoSize = true;
            this.labelAlpha3.Location = new System.Drawing.Point(12, 93);
            this.labelAlpha3.Name = "labelAlpha3";
            this.labelAlpha3.Size = new System.Drawing.Size(120, 13);
            this.labelAlpha3.TabIndex = 17;
            this.labelAlpha3.Text = "Kоефіцієнт згасання 3";
            // 
            // labelAlpha4
            // 
            this.labelAlpha4.AutoSize = true;
            this.labelAlpha4.Location = new System.Drawing.Point(12, 119);
            this.labelAlpha4.Name = "labelAlpha4";
            this.labelAlpha4.Size = new System.Drawing.Size(120, 13);
            this.labelAlpha4.TabIndex = 18;
            this.labelAlpha4.Text = "Kоефіцієнт згасання 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 483);
            this.Controls.Add(this.labelAlpha4);
            this.Controls.Add(this.labelAlpha3);
            this.Controls.Add(this.labelAlpha2);
            this.Controls.Add(this.labelAlpha1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWireLength);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "Form1";
            this.Text = "Стрктурна схема мсп с чрк";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxWireLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelAlpha1;
        private System.Windows.Forms.Label labelAlpha2;
        private System.Windows.Forms.Label labelAlpha3;
        private System.Windows.Forms.Label labelAlpha4;
    }
}

