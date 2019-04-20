namespace BST_Book_HW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_BookTitle = new System.Windows.Forms.Label();
            this.lbl_BookAuthor = new System.Windows.Forms.Label();
            this.lbl_BookIsbn = new System.Windows.Forms.Label();
            this.lbl_BookRating = new System.Windows.Forms.Label();
            this.txtBox_BookTitle = new System.Windows.Forms.TextBox();
            this.txtBox_BookAuthor = new System.Windows.Forms.TextBox();
            this.txtBox_ISBN = new System.Windows.Forms.TextBox();
            this.txtBox_BookRating = new System.Windows.Forms.TextBox();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_ISBNtoFind = new System.Windows.Forms.Button();
            this.txtbox_Year = new System.Windows.Forms.TextBox();
            this.lbl_year = new System.Windows.Forms.Label();
            this.btn_GetIsbn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_BookTitle
            // 
            this.lbl_BookTitle.AutoSize = true;
            this.lbl_BookTitle.Location = new System.Drawing.Point(54, 54);
            this.lbl_BookTitle.Name = "lbl_BookTitle";
            this.lbl_BookTitle.Size = new System.Drawing.Size(67, 18);
            this.lbl_BookTitle.TabIndex = 0;
            this.lbl_BookTitle.Text = "Book Title";
            // 
            // lbl_BookAuthor
            // 
            this.lbl_BookAuthor.AutoSize = true;
            this.lbl_BookAuthor.Location = new System.Drawing.Point(54, 118);
            this.lbl_BookAuthor.Name = "lbl_BookAuthor";
            this.lbl_BookAuthor.Size = new System.Drawing.Size(78, 18);
            this.lbl_BookAuthor.TabIndex = 1;
            this.lbl_BookAuthor.Text = "Book Author";
            // 
            // lbl_BookIsbn
            // 
            this.lbl_BookIsbn.AutoSize = true;
            this.lbl_BookIsbn.Location = new System.Drawing.Point(57, 168);
            this.lbl_BookIsbn.Name = "lbl_BookIsbn";
            this.lbl_BookIsbn.Size = new System.Drawing.Size(64, 18);
            this.lbl_BookIsbn.TabIndex = 2;
            this.lbl_BookIsbn.Text = "Book ISBN";
            // 
            // lbl_BookRating
            // 
            this.lbl_BookRating.AutoSize = true;
            this.lbl_BookRating.Location = new System.Drawing.Point(54, 228);
            this.lbl_BookRating.Name = "lbl_BookRating";
            this.lbl_BookRating.Size = new System.Drawing.Size(75, 18);
            this.lbl_BookRating.TabIndex = 3;
            this.lbl_BookRating.Text = "Book Rating";
            // 
            // txtBox_BookTitle
            // 
            this.txtBox_BookTitle.Location = new System.Drawing.Point(141, 51);
            this.txtBox_BookTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_BookTitle.Name = "txtBox_BookTitle";
            this.txtBox_BookTitle.Size = new System.Drawing.Size(244, 21);
            this.txtBox_BookTitle.TabIndex = 4;
            // 
            // txtBox_BookAuthor
            // 
            this.txtBox_BookAuthor.Location = new System.Drawing.Point(141, 115);
            this.txtBox_BookAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_BookAuthor.Name = "txtBox_BookAuthor";
            this.txtBox_BookAuthor.Size = new System.Drawing.Size(244, 21);
            this.txtBox_BookAuthor.TabIndex = 5;
            // 
            // txtBox_ISBN
            // 
            this.txtBox_ISBN.Location = new System.Drawing.Point(141, 168);
            this.txtBox_ISBN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_ISBN.Name = "txtBox_ISBN";
            this.txtBox_ISBN.Size = new System.Drawing.Size(144, 21);
            this.txtBox_ISBN.TabIndex = 6;
            // 
            // txtBox_BookRating
            // 
            this.txtBox_BookRating.Location = new System.Drawing.Point(141, 225);
            this.txtBox_BookRating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_BookRating.Name = "txtBox_BookRating";
            this.txtBox_BookRating.Size = new System.Drawing.Size(144, 21);
            this.txtBox_BookRating.TabIndex = 7;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Submit.Location = new System.Drawing.Point(33, 410);
            this.Btn_Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(99, 68);
            this.Btn_Submit.TabIndex = 8;
            this.Btn_Submit.Text = "Submitt New Book";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_ISBNtoFind
            // 
            this.Btn_ISBNtoFind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_ISBNtoFind.Location = new System.Drawing.Point(166, 410);
            this.Btn_ISBNtoFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_ISBNtoFind.Name = "Btn_ISBNtoFind";
            this.Btn_ISBNtoFind.Size = new System.Drawing.Size(119, 68);
            this.Btn_ISBNtoFind.TabIndex = 9;
            this.Btn_ISBNtoFind.Text = "Enter ISBN then Click to Find";
            this.Btn_ISBNtoFind.UseVisualStyleBackColor = true;
            this.Btn_ISBNtoFind.Click += new System.EventHandler(this.Btn_ISBNtoFind_Click);
            // 
            // txtbox_Year
            // 
            this.txtbox_Year.Location = new System.Drawing.Point(141, 282);
            this.txtbox_Year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_Year.Name = "txtbox_Year";
            this.txtbox_Year.Size = new System.Drawing.Size(144, 21);
            this.txtbox_Year.TabIndex = 10;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(54, 282);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(69, 18);
            this.lbl_year.TabIndex = 11;
            this.lbl_year.Text = "Book Year:";
            // 
            // btn_GetIsbn
            // 
            this.btn_GetIsbn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GetIsbn.Location = new System.Drawing.Point(566, 394);
            this.btn_GetIsbn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_GetIsbn.Name = "btn_GetIsbn";
            this.btn_GetIsbn.Size = new System.Drawing.Size(99, 68);
            this.btn_GetIsbn.TabIndex = 13;
            this.btn_GetIsbn.Text = "Get all ISBNs";
            this.btn_GetIsbn.UseVisualStyleBackColor = true;
            this.btn_GetIsbn.Click += new System.EventHandler(this.btn_GetIsbn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.Location = new System.Drawing.Point(490, 157);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(175, 175);
            this.dataGridView.TabIndex = 14;
            // 
            // btn_Remove
            // 
            this.btn_Remove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Remove.Location = new System.Drawing.Point(435, 394);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(99, 68);
            this.btn_Remove.TabIndex = 15;
            this.btn_Remove.Text = "Remove From ISBN";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(716, 588);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_GetIsbn);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.txtbox_Year);
            this.Controls.Add(this.Btn_ISBNtoFind);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.txtBox_BookRating);
            this.Controls.Add(this.txtBox_ISBN);
            this.Controls.Add(this.txtBox_BookAuthor);
            this.Controls.Add(this.txtBox_BookTitle);
            this.Controls.Add(this.lbl_BookRating);
            this.Controls.Add(this.lbl_BookIsbn);
            this.Controls.Add(this.lbl_BookAuthor);
            this.Controls.Add(this.lbl_BookTitle);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BookTitle;
        private System.Windows.Forms.Label lbl_BookAuthor;
        private System.Windows.Forms.Label lbl_BookIsbn;
        private System.Windows.Forms.Label lbl_BookRating;
        private System.Windows.Forms.TextBox txtBox_BookTitle;
        private System.Windows.Forms.TextBox txtBox_BookAuthor;
        private System.Windows.Forms.TextBox txtBox_ISBN;
        private System.Windows.Forms.TextBox txtBox_BookRating;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_ISBNtoFind;
        private System.Windows.Forms.TextBox txtbox_Year;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Button btn_GetIsbn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Remove;
    }
}

