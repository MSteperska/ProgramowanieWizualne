﻿namespace WindowsFormsApp1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.load_button = new System.Windows.Forms.Button();
            this.onlygreen_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(66, 279);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(138, 46);
            this.load_button.TabIndex = 1;
            this.load_button.Text = "Wczytaj";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // onlygreen_button
            // 
            this.onlygreen_button.Location = new System.Drawing.Point(438, 57);
            this.onlygreen_button.Name = "onlygreen_button";
            this.onlygreen_button.Size = new System.Drawing.Size(136, 50);
            this.onlygreen_button.TabIndex = 2;
            this.onlygreen_button.Text = "Only green";
            this.onlygreen_button.UseVisualStyleBackColor = true;
            this.onlygreen_button.Click += new System.EventHandler(this.onlygreen_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.onlygreen_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button onlygreen_button;
        private System.Windows.Forms.Button button1;
    }
}