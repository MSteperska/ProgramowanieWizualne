namespace WindowsFormsApp1
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
            this.Add_button = new System.Windows.Forms.Button();
            this.Remove_button = new System.Windows.Forms.Button();
            this.SaveCSV_button = new System.Windows.Forms.Button();
            this.LoadCSV_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search_button = new System.Windows.Forms.Button();
            this.SaveXML_button = new System.Windows.Forms.Button();
            this.LoadXML_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(110, 399);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(97, 35);
            this.Add_button.TabIndex = 0;
            this.Add_button.Text = "ADD";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(110, 453);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(97, 35);
            this.Remove_button.TabIndex = 1;
            this.Remove_button.Text = "REMOVE";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // SaveCSV_button
            // 
            this.SaveCSV_button.Location = new System.Drawing.Point(450, 390);
            this.SaveCSV_button.Name = "SaveCSV_button";
            this.SaveCSV_button.Size = new System.Drawing.Size(129, 52);
            this.SaveCSV_button.TabIndex = 2;
            this.SaveCSV_button.Text = "SAVE TO .CSV\r\n";
            this.SaveCSV_button.UseVisualStyleBackColor = true;
            this.SaveCSV_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // LoadCSV_button
            // 
            this.LoadCSV_button.Location = new System.Drawing.Point(610, 390);
            this.LoadCSV_button.Name = "LoadCSV_button";
            this.LoadCSV_button.Size = new System.Drawing.Size(134, 52);
            this.LoadCSV_button.TabIndex = 3;
            this.LoadCSV_button.Text = "LOAD FROM .CSV";
            this.LoadCSV_button.UseVisualStyleBackColor = true;
            this.LoadCSV_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.Genres,
            this.Stars,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(43, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(814, 332);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Title
            // 
            this.Title.HeaderText = "TITLE";
            this.Title.MinimumWidth = 8;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 150;
            // 
            // Author
            // 
            this.Author.HeaderText = "AUTHOR";
            this.Author.MinimumWidth = 8;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 150;
            // 
            // Genres
            // 
            this.Genres.HeaderText = "GENRES";
            this.Genres.MinimumWidth = 8;
            this.Genres.Name = "Genres";
            this.Genres.ReadOnly = true;
            this.Genres.Width = 150;
            // 
            // Stars
            // 
            this.Stars.HeaderText = "STARS";
            this.Stars.MinimumWidth = 8;
            this.Stars.Name = "Stars";
            this.Stars.ReadOnly = true;
            this.Stars.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "PRICE";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(275, 428);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(97, 34);
            this.Search_button.TabIndex = 5;
            this.Search_button.Text = "SEARCH";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveXML_button
            // 
            this.SaveXML_button.Location = new System.Drawing.Point(450, 463);
            this.SaveXML_button.Name = "SaveXML_button";
            this.SaveXML_button.Size = new System.Drawing.Size(129, 54);
            this.SaveXML_button.TabIndex = 6;
            this.SaveXML_button.Text = "SAVE TO .XML";
            this.SaveXML_button.UseVisualStyleBackColor = true;
            // 
            // LoadXML_button
            // 
            this.LoadXML_button.Location = new System.Drawing.Point(610, 463);
            this.LoadXML_button.Name = "LoadXML_button";
            this.LoadXML_button.Size = new System.Drawing.Size(134, 54);
            this.LoadXML_button.TabIndex = 7;
            this.LoadXML_button.Text = "LOAD FROM .XML";
            this.LoadXML_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 529);
            this.Controls.Add(this.LoadXML_button);
            this.Controls.Add(this.SaveXML_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LoadCSV_button);
            this.Controls.Add(this.SaveCSV_button);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.Add_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.Button SaveCSV_button;
        private System.Windows.Forms.Button LoadCSV_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button SaveXML_button;
        private System.Windows.Forms.Button LoadXML_button;
    }
}