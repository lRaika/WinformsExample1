﻿namespace ExampleFirstWinForm
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
            this.buttonForShowInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonForShowInfo
            // 
            this.buttonForShowInfo.Location = new System.Drawing.Point(12, 12);
            this.buttonForShowInfo.Name = "buttonForShowInfo";
            this.buttonForShowInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonForShowInfo.TabIndex = 0;
            this.buttonForShowInfo.Text = "Кнопка";
            this.buttonForShowInfo.UseVisualStyleBackColor = true;
            this.buttonForShowInfo.Click += new System.EventHandler(this.ButtonForShowInfo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 375);
            this.Controls.Add(this.buttonForShowInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonForShowInfo;
    }
}

