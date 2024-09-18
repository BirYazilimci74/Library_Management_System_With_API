namespace LibraryManagementSystemWithAPI.UI
{
    partial class BorrowBookMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBookMenu));
            btnBorrow = new Button();
            tbxSearchBookName = new TextBox();
            dgvBooks = new DataGridView();
            tbxSearchAuthor = new TextBox();
            panel2 = new Panel();
            btnAuthorSearch = new Button();
            panel1 = new Panel();
            btnNameSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.CornflowerBlue;
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold);
            btnBorrow.Location = new Point(870, 90);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(100, 50);
            btnBorrow.TabIndex = 22;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // tbxSearchBookName
            // 
            tbxSearchBookName.BackColor = Color.White;
            tbxSearchBookName.BorderStyle = BorderStyle.None;
            tbxSearchBookName.Cursor = Cursors.IBeam;
            tbxSearchBookName.Location = new Point(3, 10);
            tbxSearchBookName.Name = "tbxSearchBookName";
            tbxSearchBookName.Size = new Size(350, 15);
            tbxSearchBookName.TabIndex = 23;
            tbxSearchBookName.Text = "Book Name";
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AllowUserToOrderColumns = true;
            dgvBooks.AllowUserToResizeColumns = false;
            dgvBooks.AllowUserToResizeRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvBooks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Cursor = Cursors.Hand;
            dgvBooks.EditMode = DataGridViewEditMode.EditOnF2;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.GridColor = SystemColors.ActiveCaptionText;
            dgvBooks.Location = new Point(55, 76);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(800, 400);
            dgvBooks.TabIndex = 24;
            // 
            // tbxSearchAuthor
            // 
            tbxSearchAuthor.BackColor = Color.White;
            tbxSearchAuthor.BorderStyle = BorderStyle.None;
            tbxSearchAuthor.Cursor = Cursors.IBeam;
            tbxSearchAuthor.Location = new Point(3, 10);
            tbxSearchAuthor.Name = "tbxSearchAuthor";
            tbxSearchAuthor.Size = new Size(350, 15);
            tbxSearchAuthor.TabIndex = 26;
            tbxSearchAuthor.Text = "Author";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnAuthorSearch);
            panel2.Controls.Add(tbxSearchAuthor);
            panel2.Location = new Point(460, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 36);
            panel2.TabIndex = 30;
            // 
            // btnAuthorSearch
            // 
            btnAuthorSearch.BackColor = Color.CornflowerBlue;
            btnAuthorSearch.Dock = DockStyle.Right;
            btnAuthorSearch.FlatStyle = FlatStyle.Flat;
            btnAuthorSearch.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold);
            btnAuthorSearch.Image = (Image)resources.GetObject("btnAuthorSearch.Image");
            btnAuthorSearch.Location = new Point(357, 0);
            btnAuthorSearch.Name = "btnAuthorSearch";
            btnAuthorSearch.Size = new Size(36, 34);
            btnAuthorSearch.TabIndex = 27;
            btnAuthorSearch.UseVisualStyleBackColor = false;
            btnAuthorSearch.Click += btnAuthorSearch_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnNameSearch);
            panel1.Controls.Add(tbxSearchBookName);
            panel1.Location = new Point(55, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 36);
            panel1.TabIndex = 29;
            // 
            // btnNameSearch
            // 
            btnNameSearch.BackColor = Color.CornflowerBlue;
            btnNameSearch.Dock = DockStyle.Right;
            btnNameSearch.FlatStyle = FlatStyle.Flat;
            btnNameSearch.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold);
            btnNameSearch.Image = (Image)resources.GetObject("btnNameSearch.Image");
            btnNameSearch.Location = new Point(357, 0);
            btnNameSearch.Name = "btnNameSearch";
            btnNameSearch.Size = new Size(36, 34);
            btnNameSearch.TabIndex = 27;
            btnNameSearch.UseVisualStyleBackColor = false;
            btnNameSearch.Click += btnNameSearch_Click;
            // 
            // BorrowBookMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 210, 245);
            ClientSize = new Size(982, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnBorrow);
            Controls.Add(dgvBooks);
            Font = new Font("Microsoft Sans Serif", 7.8F);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "BorrowBookMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrowBookMenu";
            Load += BorrowBookMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBorrow;
        private TextBox tbxSearchBookName;
        private DataGridView dgvBooks;
        private TextBox tbxSearchAuthor;
        private Panel panel2;
        private Button btnAuthorSearch;
        private Panel panel1;
        private Button btnNameSearch;
    }
}