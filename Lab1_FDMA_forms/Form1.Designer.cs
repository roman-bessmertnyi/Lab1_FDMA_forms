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
            this.textBoxServicedBoosterStationPart = new System.Windows.Forms.TextBox();
            this.textBoxBoostedWiresNumber = new System.Windows.Forms.TextBox();
            this.textBoxBoosterWireLength = new System.Windows.Forms.TextBox();
            this.textBoxBoosterStationNumber = new System.Windows.Forms.TextBox();
            this.textBoxServicedBoosterStationNumber = new System.Windows.Forms.TextBox();
            this.textBoxUnservicedBoosterStationNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(151, 246);
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
            this.textBoxWireLength.Text = "90";
            // 
            // textBoxServicedBoosterStationPart
            // 
            this.textBoxServicedBoosterStationPart.Location = new System.Drawing.Point(251, 38);
            this.textBoxServicedBoosterStationPart.Name = "textBoxServicedBoosterStationPart";
            this.textBoxServicedBoosterStationPart.Size = new System.Drawing.Size(141, 20);
            this.textBoxServicedBoosterStationPart.TabIndex = 2;
            this.textBoxServicedBoosterStationPart.Text = "0,2";
            // 
            // textBoxBoostedWiresNumber
            // 
            this.textBoxBoostedWiresNumber.Location = new System.Drawing.Point(251, 64);
            this.textBoxBoostedWiresNumber.Name = "textBoxBoostedWiresNumber";
            this.textBoxBoostedWiresNumber.Size = new System.Drawing.Size(141, 20);
            this.textBoxBoostedWiresNumber.TabIndex = 3;
            this.textBoxBoostedWiresNumber.Text = "6";
            // 
            // textBoxBoosterWireLength
            // 
            this.textBoxBoosterWireLength.Location = new System.Drawing.Point(12, 110);
            this.textBoxBoosterWireLength.Name = "textBoxBoosterWireLength";
            this.textBoxBoosterWireLength.Size = new System.Drawing.Size(148, 20);
            this.textBoxBoosterWireLength.TabIndex = 4;
            // 
            // textBoxBoosterStationNumber
            // 
            this.textBoxBoosterStationNumber.Location = new System.Drawing.Point(12, 136);
            this.textBoxBoosterStationNumber.Name = "textBoxBoosterStationNumber";
            this.textBoxBoosterStationNumber.Size = new System.Drawing.Size(148, 20);
            this.textBoxBoosterStationNumber.TabIndex = 5;
            // 
            // textBoxServicedBoosterStationNumber
            // 
            this.textBoxServicedBoosterStationNumber.Location = new System.Drawing.Point(12, 162);
            this.textBoxServicedBoosterStationNumber.Name = "textBoxServicedBoosterStationNumber";
            this.textBoxServicedBoosterStationNumber.Size = new System.Drawing.Size(148, 20);
            this.textBoxServicedBoosterStationNumber.TabIndex = 6;
            // 
            // textBoxUnservicedBoosterStationNumber
            // 
            this.textBoxUnservicedBoosterStationNumber.Location = new System.Drawing.Point(12, 188);
            this.textBoxUnservicedBoosterStationNumber.Name = "textBoxUnservicedBoosterStationNumber";
            this.textBoxUnservicedBoosterStationNumber.Size = new System.Drawing.Size(148, 20);
            this.textBoxUnservicedBoosterStationNumber.TabIndex = 7;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Частина обсуговуваних підсилювачів";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Кількість підсилюваних ділянок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Довжина підсилюваної ділянки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Кількість підсилювачів";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Кількість обслуговуваних підсилювачів";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Кількість необслуговуваних підсилювачів";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 621);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUnservicedBoosterStationNumber);
            this.Controls.Add(this.textBoxServicedBoosterStationNumber);
            this.Controls.Add(this.textBoxBoosterStationNumber);
            this.Controls.Add(this.textBoxBoosterWireLength);
            this.Controls.Add(this.textBoxBoostedWiresNumber);
            this.Controls.Add(this.textBoxServicedBoosterStationPart);
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
        private System.Windows.Forms.TextBox textBoxServicedBoosterStationPart;
        private System.Windows.Forms.TextBox textBoxBoostedWiresNumber;
        private System.Windows.Forms.TextBox textBoxBoosterWireLength;
        private System.Windows.Forms.TextBox textBoxBoosterStationNumber;
        private System.Windows.Forms.TextBox textBoxServicedBoosterStationNumber;
        private System.Windows.Forms.TextBox textBoxUnservicedBoosterStationNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

