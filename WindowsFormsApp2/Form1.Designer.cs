namespace WindowsFormsApp2
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
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.txt21 = new System.Windows.Forms.TextBox();
            this.txt22 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%",
            ">",
            "<"});
            this.cmbOperation.Location = new System.Drawing.Point(113, 92);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(121, 24);
            this.cmbOperation.TabIndex = 0;
            this.cmbOperation.Text = "+";
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.cmbOperation_SelectedIndexChanged);
            // 
            // txt11
            // 
            this.txt11.Location = new System.Drawing.Point(58, 12);
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(100, 22);
            this.txt11.TabIndex = 1;
            this.txt11.TextChanged += new System.EventHandler(this.txt11_TextChanged);
            // 
            // txt12
            // 
            this.txt12.Location = new System.Drawing.Point(190, 12);
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(100, 22);
            this.txt12.TabIndex = 2;
            this.txt12.TextChanged += new System.EventHandler(this.txt12_TextChanged);
            // 
            // txt21
            // 
            this.txt21.Location = new System.Drawing.Point(58, 53);
            this.txt21.Name = "txt21";
            this.txt21.Size = new System.Drawing.Size(100, 22);
            this.txt21.TabIndex = 3;
            this.txt21.TextChanged += new System.EventHandler(this.txt21_TextChanged);
            // 
            // txt22
            // 
            this.txt22.Location = new System.Drawing.Point(190, 53);
            this.txt22.Name = "txt22";
            this.txt22.Size = new System.Drawing.Size(100, 22);
            this.txt22.TabIndex = 4;
            this.txt22.TextChanged += new System.EventHandler(this.txt22_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(58, 134);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(236, 22);
            this.txtResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "i";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "i";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "z1 = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "z2 = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "+ ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "+ ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 180);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txt22);
            this.Controls.Add(this.txt21);
            this.Controls.Add(this.txt12);
            this.Controls.Add(this.txt11);
            this.Controls.Add(this.cmbOperation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.TextBox txt12;
        private System.Windows.Forms.TextBox txt21;
        private System.Windows.Forms.TextBox txt22;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

