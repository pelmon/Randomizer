﻿namespace Randomizer
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
            this.ButtonOfRandom = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonOfRandom
            // 
            this.ButtonOfRandom.Location = new System.Drawing.Point(12, 57);
            this.ButtonOfRandom.Name = "ButtonOfRandom";
            this.ButtonOfRandom.Size = new System.Drawing.Size(210, 126);
            this.ButtonOfRandom.TabIndex = 0;
            this.ButtonOfRandom.Text = "Randomize";
            this.ButtonOfRandom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ButtonOfRandom.UseVisualStyleBackColor = true;
            this.ButtonOfRandom.Click += new System.EventHandler(this.ButtonOfRandom_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 200);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonOfRandom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOfRandom;
        private System.Windows.Forms.TextBox textBox1;
    }
}

