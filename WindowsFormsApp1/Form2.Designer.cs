namespace WindowsFormsApp1
{
    partial class Form2
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
            this.Title_text = new System.Windows.Forms.TextBox();
            this.Price_text = new System.Windows.Forms.TextBox();
            this.Stars_text = new System.Windows.Forms.TextBox();
            this.Genres_text = new System.Windows.Forms.TextBox();
            this.Author_text = new System.Windows.Forms.TextBox();
            this.Title_label = new System.Windows.Forms.Label();
            this.Author_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Stars_label = new System.Windows.Forms.Label();
            this.Price_label = new System.Windows.Forms.Label();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Return_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title_text
            // 
            this.Title_text.Location = new System.Drawing.Point(107, 73);
            this.Title_text.Name = "Title_text";
            this.Title_text.Size = new System.Drawing.Size(147, 26);
            this.Title_text.TabIndex = 0;
            this.Title_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Price_text
            // 
            this.Price_text.Location = new System.Drawing.Point(107, 424);
            this.Price_text.Name = "Price_text";
            this.Price_text.Size = new System.Drawing.Size(147, 26);
            this.Price_text.TabIndex = 1;
            this.Price_text.TextChanged += new System.EventHandler(this.Price_text_TextChanged);
            // 
            // Stars_text
            // 
            this.Stars_text.Location = new System.Drawing.Point(107, 338);
            this.Stars_text.Name = "Stars_text";
            this.Stars_text.Size = new System.Drawing.Size(147, 26);
            this.Stars_text.TabIndex = 2;
            this.Stars_text.TextChanged += new System.EventHandler(this.Stars_text_TextChanged);
            // 
            // Genres_text
            // 
            this.Genres_text.Location = new System.Drawing.Point(107, 251);
            this.Genres_text.Name = "Genres_text";
            this.Genres_text.Size = new System.Drawing.Size(147, 26);
            this.Genres_text.TabIndex = 3;
            this.Genres_text.TextChanged += new System.EventHandler(this.Genres_text_TextChanged);
            // 
            // Author_text
            // 
            this.Author_text.Location = new System.Drawing.Point(107, 161);
            this.Author_text.Name = "Author_text";
            this.Author_text.Size = new System.Drawing.Size(147, 26);
            this.Author_text.TabIndex = 4;
            this.Author_text.TextChanged += new System.EventHandler(this.Author_text_TextChanged);
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Location = new System.Drawing.Point(156, 50);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(52, 20);
            this.Title_label.TabIndex = 5;
            this.Title_label.Text = "TITLE";
            this.Title_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Author_label
            // 
            this.Author_label.AutoSize = true;
            this.Author_label.Location = new System.Drawing.Point(148, 138);
            this.Author_label.Name = "Author_label";
            this.Author_label.Size = new System.Drawing.Size(77, 20);
            this.Author_label.TabIndex = 6;
            this.Author_label.Text = "AUTHOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "GENRES";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Stars_label
            // 
            this.Stars_label.AutoSize = true;
            this.Stars_label.Location = new System.Drawing.Point(148, 315);
            this.Stars_label.Name = "Stars_label";
            this.Stars_label.Size = new System.Drawing.Size(63, 20);
            this.Stars_label.TabIndex = 8;
            this.Stars_label.Text = "STARS";
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Location = new System.Drawing.Point(148, 401);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(58, 20);
            this.Price_label.TabIndex = 9;
            this.Price_label.Text = "PRICE";
            // 
            // Accept_button
            // 
            this.Accept_button.Location = new System.Drawing.Point(461, 311);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(126, 37);
            this.Accept_button.TabIndex = 10;
            this.Accept_button.Text = "ACCEPT";
            this.Accept_button.UseVisualStyleBackColor = true;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Return_button
            // 
            this.Return_button.Location = new System.Drawing.Point(461, 373);
            this.Return_button.Name = "Return_button";
            this.Return_button.Size = new System.Drawing.Size(126, 33);
            this.Return_button.TabIndex = 11;
            this.Return_button.Text = "RETURN";
            this.Return_button.UseVisualStyleBackColor = true;
            this.Return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.Return_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.Stars_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Author_label);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.Author_text);
            this.Controls.Add(this.Genres_text);
            this.Controls.Add(this.Stars_text);
            this.Controls.Add(this.Price_text);
            this.Controls.Add(this.Title_text);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title_text;
        private System.Windows.Forms.TextBox Price_text;
        private System.Windows.Forms.TextBox Stars_text;
        private System.Windows.Forms.TextBox Genres_text;
        private System.Windows.Forms.TextBox Author_text;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label Author_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Stars_label;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Button Return_button;
    }
}