﻿namespace TomBilSkisse
{
    partial class SjaførOppdragsListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 381);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ta oppdrag...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(434, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nær meg";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // SjaførOppdragsListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "SjaførOppdragsListe";
            this.Text = "SjaførOppdragsListe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}