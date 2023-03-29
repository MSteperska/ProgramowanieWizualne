namespace WindowsFormsApp1
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search3_button = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTHOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STARS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Search3_button
            // 
            this.Search3_button.Location = new System.Drawing.Point(634, 24);
            this.Search3_button.Name = "Search3_button";
            this.Search3_button.Size = new System.Drawing.Size(105, 39);
            this.Search3_button.TabIndex = 1;
            this.Search3_button.Text = "SEARCH";
            this.Search3_button.UseVisualStyleBackColor = true;
            this.Search3_button.Click += new System.EventHandler(this.Search3_button_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TITLE,
            this.AUTHOR,
            this.GENRES,
            this.STARS,
            this.PRICE});
            this.dataGridView2.Location = new System.Drawing.Point(36, 75);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(703, 295);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TITLE
            // 
            this.TITLE.HeaderText = "TITLE";
            this.TITLE.MinimumWidth = 8;
            this.TITLE.Name = "TITLE";
            this.TITLE.ReadOnly = true;
            this.TITLE.Width = 150;
            // 
            // AUTHOR
            // 
            this.AUTHOR.HeaderText = "AUTHOR";
            this.AUTHOR.MinimumWidth = 8;
            this.AUTHOR.Name = "AUTHOR";
            this.AUTHOR.ReadOnly = true;
            this.AUTHOR.Width = 150;
            // 
            // GENRES
            // 
            this.GENRES.HeaderText = "GENRES";
            this.GENRES.MinimumWidth = 8;
            this.GENRES.Name = "GENRES";
            this.GENRES.ReadOnly = true;
            this.GENRES.Width = 150;
            // 
            // STARS
            // 
            this.STARS.HeaderText = "STARS";
            this.STARS.MinimumWidth = 8;
            this.STARS.Name = "STARS";
            this.STARS.ReadOnly = true;
            this.STARS.Width = 150;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.MinimumWidth = 8;
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            this.PRICE.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 443);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Search3_button);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search3_button;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTHOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn STARS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
    }
}