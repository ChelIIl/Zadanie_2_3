namespace Zadanie_2_3
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
            this.Найти = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.D1 = new System.Windows.Forms.TextBox();
            this.D2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.whille_t = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dowhile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.for_t = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск целого числа из диапазона от А до В \r\n      оканчивающегося на цифру x или " +
    "y.";
            // 
            // Найти
            // 
            this.Найти.Location = new System.Drawing.Point(204, 291);
            this.Найти.Name = "Найти";
            this.Найти.Size = new System.Drawing.Size(103, 38);
            this.Найти.TabIndex = 1;
            this.Найти.Text = "Поиск";
            this.Найти.UseVisualStyleBackColor = true;
            this.Найти.Click += new System.EventHandler(this.Найти_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "А:";
            // 
            // D1
            // 
            this.D1.Location = new System.Drawing.Point(98, 119);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(100, 20);
            this.D1.TabIndex = 3;
            // 
            // D2
            // 
            this.D2.Location = new System.Drawing.Point(98, 163);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(100, 20);
            this.D2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "B:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(329, 119);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 20);
            this.num1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(306, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "X:";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(329, 163);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 20);
            this.num2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(306, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y:";
            // 
            // whille_t
            // 
            this.whille_t.Location = new System.Drawing.Point(71, 235);
            this.whille_t.Name = "whille_t";
            this.whille_t.ReadOnly = true;
            this.whille_t.Size = new System.Drawing.Size(100, 20);
            this.whille_t.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "while:";
            // 
            // dowhile
            // 
            this.dowhile.Location = new System.Drawing.Point(271, 235);
            this.dowhile.Name = "dowhile";
            this.dowhile.ReadOnly = true;
            this.dowhile.Size = new System.Drawing.Size(100, 20);
            this.dowhile.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(186, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "do while:";
            // 
            // for_t
            // 
            this.for_t.Location = new System.Drawing.Point(409, 236);
            this.for_t.Name = "for_t";
            this.for_t.ReadOnly = true;
            this.for_t.Size = new System.Drawing.Size(100, 20);
            this.for_t.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(377, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "for:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 342);
            this.Controls.Add(this.for_t);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dowhile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.whille_t);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Найти);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Найти;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox D1;
        private System.Windows.Forms.TextBox D2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox whille_t;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dowhile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox for_t;
        private System.Windows.Forms.Label label8;
    }
}

