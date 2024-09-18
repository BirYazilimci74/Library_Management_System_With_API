namespace LibraryManagementSystemWithAPI.UI
{
    partial class ReturnBookMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookMenu));
            dgvBorrowedBooks = new DataGridView();
            tbxSearchBookName = new TextBox();
            btnReturn = new Button();
            btnOverdue = new Button();
            panel1 = new Panel();
            btnSearchBookName = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.AllowUserToAddRows = false;
            dgvBorrowedBooks.AllowUserToDeleteRows = false;
            dgvBorrowedBooks.AllowUserToOrderColumns = true;
            dgvBorrowedBooks.AllowUserToResizeColumns = false;
            dgvBorrowedBooks.AllowUserToResizeRows = false;
            dgvBorrowedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowedBooks.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvBorrowedBooks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBorrowedBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Cursor = Cursors.Hand;
            dgvBorrowedBooks.EditMode = DataGridViewEditMode.EditOnF2;
            dgvBorrowedBooks.EnableHeadersVisualStyles = false;
            dgvBorrowedBooks.GridColor = SystemColors.ActiveCaptionText;
            dgvBorrowedBooks.Location = new Point(60, 80);
            dgvBorrowedBooks.MultiSelect = false;
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.ReadOnly = true;
            dgvBorrowedBooks.RowHeadersVisible = false;
            dgvBorrowedBooks.RowHeadersWidth = 51;
            dgvBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowedBooks.Size = new Size(800, 400);
            dgvBorrowedBooks.TabIndex = 20;
            // 
            // tbxSearchBookName
            // 
            tbxSearchBookName.BackColor = Color.White;
            tbxSearchBookName.BorderStyle = BorderStyle.None;
            tbxSearchBookName.Cursor = Cursors.IBeam;
            tbxSearchBookName.Location = new Point(7, 10);
            tbxSearchBookName.Name = "tbxSearchBookName";
            tbxSearchBookName.Size = new Size(604, 15);
            tbxSearchBookName.TabIndex = 17;
            tbxSearchBookName.Text = "Book Name";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.CornflowerBlue;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold);
            btnReturn.Location = new Point(870, 90);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(100, 50);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnOverdue
            // 
            btnOverdue.BackColor = Color.CornflowerBlue;
            btnOverdue.FlatStyle = FlatStyle.Flat;
            btnOverdue.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold);
            btnOverdue.Location = new Point(730, 35);
            btnOverdue.Name = "btnOverdue";
            btnOverdue.Size = new Size(130, 36);
            btnOverdue.TabIndex = 23;
            btnOverdue.Text = "Overdue List";
            btnOverdue.UseVisualStyleBackColor = false;
            btnOverdue.Click += btnOverdue_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tbxSearchBookName);
            panel1.Location = new Point(60, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 36);
            panel1.TabIndex = 24;
            // 
            // btnSearchBookName
            // 
            btnSearchBookName.BackColor = Color.CornflowerBlue;
            btnSearchBookName.FlatStyle = FlatStyle.Flat;
            btnSearchBookName.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold);
            btnSearchBookName.Image = (Image)resources.GetObject("btnSearchBookName.Image");
            btnSearchBookName.Location = new Point(678, 35);
            btnSearchBookName.Name = "btnSearchBookName";
            btnSearchBookName.Size = new Size(36, 36);
            btnSearchBookName.TabIndex = 25;
            btnSearchBookName.UseVisualStyleBackColor = false;
            btnSearchBookName.Click += btnSearchBookName_Click;
            // 
            // ReturnBookMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 210, 245);
            ClientSize = new Size(982, 553);
            Controls.Add(btnSearchBookName);
            Controls.Add(panel1);
            Controls.Add(btnOverdue);
            Controls.Add(btnReturn);
            Controls.Add(dgvBorrowedBooks);
            Font = new Font("Microsoft Sans Serif", 7.8F);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "ReturnBookMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBookMenu";
            Load += ReturnBookMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvBorrowedBooks;
        private TextBox tbxSearchBookName;
        private Button btnReturn;
        private Button btnOverdue;
        private Panel panel1;
        private Button btnSearchBookName;
    }
}