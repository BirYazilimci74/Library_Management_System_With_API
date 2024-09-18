namespace LibraryManagementSystemWithAPI.UI
{
    partial class ManageBooksMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooksMenu));
            tbxSearchBookName = new TextBox();
            tbxSearchAuthor = new TextBox();
            tbxAddName = new TextBox();
            tbxAddAuthor = new TextBox();
            dgvBooks = new DataGridView();
            btnDelete = new Button();
            cmbAddCatagory = new ComboBox();
            numAddStock = new NumericUpDown();
            gbAdd = new GroupBox();
            panel5 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            lblAddCatagory = new Label();
            lblAddAuthor = new Label();
            lblAddStock = new Label();
            lblAddName = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            numeUpdateStock = new NumericUpDown();
            gbUpdate = new GroupBox();
            panel10 = new Panel();
            numUpdateStock = new NumericUpDown();
            lblUpdateCatagory = new Label();
            panel9 = new Panel();
            cbxUpdateCatagory = new ComboBox();
            lblUpdateAuthor = new Label();
            panel8 = new Panel();
            tbxUpdateAuthor = new TextBox();
            lblUpdateStock = new Label();
            panel7 = new Panel();
            tbxUpdateName = new TextBox();
            lblUpdateName = new Label();
            btnSearchBookName = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnSearchAuthor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAddStock).BeginInit();
            gbAdd.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeUpdateStock).BeginInit();
            gbUpdate.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpdateStock).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tbxSearchBookName
            // 
            tbxSearchBookName.BorderStyle = BorderStyle.None;
            tbxSearchBookName.Font = new Font("Microsoft Sans Serif", 7.8F);
            tbxSearchBookName.Location = new Point(3, 10);
            tbxSearchBookName.Name = "tbxSearchBookName";
            tbxSearchBookName.Size = new Size(356, 15);
            tbxSearchBookName.TabIndex = 8;
            tbxSearchBookName.Text = "Book Name";
            // 
            // tbxSearchAuthor
            // 
            tbxSearchAuthor.BorderStyle = BorderStyle.None;
            tbxSearchAuthor.Font = new Font("Microsoft Sans Serif", 7.8F);
            tbxSearchAuthor.Location = new Point(3, 10);
            tbxSearchAuthor.Name = "tbxSearchAuthor";
            tbxSearchAuthor.Size = new Size(300, 15);
            tbxSearchAuthor.TabIndex = 16;
            tbxSearchAuthor.Text = "Author";
            // 
            // tbxAddName
            // 
            tbxAddName.BorderStyle = BorderStyle.None;
            tbxAddName.Font = new Font("Microsoft Sans Serif", 7.8F);
            tbxAddName.Location = new Point(3, 6);
            tbxAddName.Name = "tbxAddName";
            tbxAddName.Size = new Size(172, 15);
            tbxAddName.TabIndex = 4;
            // 
            // tbxAddAuthor
            // 
            tbxAddAuthor.BorderStyle = BorderStyle.None;
            tbxAddAuthor.Font = new Font("Microsoft Sans Serif", 7.8F);
            tbxAddAuthor.Location = new Point(3, 6);
            tbxAddAuthor.Name = "tbxAddAuthor";
            tbxAddAuthor.Size = new Size(172, 15);
            tbxAddAuthor.TabIndex = 5;
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
            dgvBooks.Location = new Point(100, 50);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(800, 180);
            dgvBooks.TabIndex = 0;
            dgvBooks.CellClick += dgvBooks_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.CornflowerBlue;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Myanmar Text", 7.8F, FontStyle.Bold);
            btnDelete.Location = new Point(787, 236);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 35);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbAddCatagory
            // 
            cmbAddCatagory.BackColor = Color.White;
            cmbAddCatagory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddCatagory.DropDownWidth = 178;
            cmbAddCatagory.Font = new Font("Microsoft Sans Serif", 7.8F);
            cmbAddCatagory.FormattingEnabled = true;
            cmbAddCatagory.Location = new Point(0, 3);
            cmbAddCatagory.Name = "cmbAddCatagory";
            cmbAddCatagory.Size = new Size(178, 24);
            cmbAddCatagory.TabIndex = 3;
            // 
            // numAddStock
            // 
            numAddStock.BorderStyle = BorderStyle.None;
            numAddStock.Font = new Font("Microsoft Sans Serif", 7.8F);
            numAddStock.Location = new Point(3, 7);
            numAddStock.Name = "numAddStock";
            numAddStock.Size = new Size(172, 18);
            numAddStock.TabIndex = 7;
            // 
            // gbAdd
            // 
            gbAdd.Controls.Add(panel5);
            gbAdd.Controls.Add(panel6);
            gbAdd.Controls.Add(panel4);
            gbAdd.Controls.Add(panel3);
            gbAdd.Controls.Add(lblAddCatagory);
            gbAdd.Controls.Add(lblAddAuthor);
            gbAdd.Controls.Add(lblAddStock);
            gbAdd.Controls.Add(lblAddName);
            gbAdd.Location = new Point(37, 273);
            gbAdd.Name = "gbAdd";
            gbAdd.Size = new Size(415, 225);
            gbAdd.TabIndex = 14;
            gbAdd.TabStop = false;
            gbAdd.Text = "Add Book";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(numAddStock);
            panel5.Location = new Point(120, 168);
            panel5.Name = "panel5";
            panel5.Size = new Size(178, 30);
            panel5.TabIndex = 30;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(cmbAddCatagory);
            panel6.Location = new Point(120, 128);
            panel6.Name = "panel6";
            panel6.Size = new Size(178, 30);
            panel6.TabIndex = 30;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(tbxAddAuthor);
            panel4.Location = new Point(120, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(178, 30);
            panel4.TabIndex = 30;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tbxAddName);
            panel3.Location = new Point(120, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 30);
            panel3.TabIndex = 29;
            // 
            // lblAddCatagory
            // 
            lblAddCatagory.AutoSize = true;
            lblAddCatagory.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblAddCatagory.Location = new Point(26, 130);
            lblAddCatagory.Name = "lblAddCatagory";
            lblAddCatagory.Size = new Size(88, 22);
            lblAddCatagory.TabIndex = 17;
            lblAddCatagory.Text = "Catagory:";
            // 
            // lblAddAuthor
            // 
            lblAddAuthor.AutoSize = true;
            lblAddAuthor.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblAddAuthor.Location = new Point(26, 90);
            lblAddAuthor.Name = "lblAddAuthor";
            lblAddAuthor.Size = new Size(63, 22);
            lblAddAuthor.TabIndex = 16;
            lblAddAuthor.Text = "Author";
            // 
            // lblAddStock
            // 
            lblAddStock.AutoSize = true;
            lblAddStock.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblAddStock.Location = new Point(26, 170);
            lblAddStock.Name = "lblAddStock";
            lblAddStock.Size = new Size(60, 22);
            lblAddStock.TabIndex = 15;
            lblAddStock.Text = "Stock:";
            // 
            // lblAddName
            // 
            lblAddName.AutoSize = true;
            lblAddName.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblAddName.Location = new Point(26, 50);
            lblAddName.Name = "lblAddName";
            lblAddName.Size = new Size(62, 22);
            lblAddName.TabIndex = 0;
            lblAddName.Text = "Name:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Myanmar Text", 7.8F, FontStyle.Bold);
            btnAdd.Location = new Point(340, 503);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 35);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Myanmar Text", 7.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(820, 503);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 35);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // numeUpdateStock
            // 
            numeUpdateStock.Location = new Point(0, 0);
            numeUpdateStock.Name = "numeUpdateStock";
            numeUpdateStock.Size = new Size(120, 27);
            numeUpdateStock.TabIndex = 0;
            // 
            // gbUpdate
            // 
            gbUpdate.Controls.Add(panel10);
            gbUpdate.Controls.Add(lblUpdateCatagory);
            gbUpdate.Controls.Add(panel9);
            gbUpdate.Controls.Add(lblUpdateAuthor);
            gbUpdate.Controls.Add(panel8);
            gbUpdate.Controls.Add(lblUpdateStock);
            gbUpdate.Controls.Add(panel7);
            gbUpdate.Controls.Add(lblUpdateName);
            gbUpdate.Location = new Point(518, 273);
            gbUpdate.Name = "gbUpdate";
            gbUpdate.Size = new Size(415, 225);
            gbUpdate.TabIndex = 18;
            gbUpdate.TabStop = false;
            gbUpdate.Text = "Update Book";
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(numUpdateStock);
            panel10.Location = new Point(120, 168);
            panel10.Name = "panel10";
            panel10.Size = new Size(178, 30);
            panel10.TabIndex = 31;
            // 
            // numUpdateStock
            // 
            numUpdateStock.BackColor = Color.White;
            numUpdateStock.BorderStyle = BorderStyle.None;
            numUpdateStock.Font = new Font("Microsoft Sans Serif", 7.8F);
            numUpdateStock.Location = new Point(3, 7);
            numUpdateStock.Name = "numUpdateStock";
            numUpdateStock.Size = new Size(172, 18);
            numUpdateStock.TabIndex = 7;
            // 
            // lblUpdateCatagory
            // 
            lblUpdateCatagory.AutoSize = true;
            lblUpdateCatagory.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblUpdateCatagory.Location = new Point(26, 130);
            lblUpdateCatagory.Name = "lblUpdateCatagory";
            lblUpdateCatagory.Size = new Size(88, 22);
            lblUpdateCatagory.TabIndex = 17;
            lblUpdateCatagory.Text = "Catagory:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(cbxUpdateCatagory);
            panel9.Location = new Point(120, 128);
            panel9.Name = "panel9";
            panel9.Size = new Size(178, 30);
            panel9.TabIndex = 31;
            // 
            // cbxUpdateCatagory
            // 
            cbxUpdateCatagory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUpdateCatagory.DropDownWidth = 178;
            cbxUpdateCatagory.Font = new Font("Microsoft Sans Serif", 7.8F);
            cbxUpdateCatagory.FormattingEnabled = true;
            cbxUpdateCatagory.Location = new Point(0, 3);
            cbxUpdateCatagory.Name = "cbxUpdateCatagory";
            cbxUpdateCatagory.Size = new Size(178, 24);
            cbxUpdateCatagory.TabIndex = 3;
            // 
            // lblUpdateAuthor
            // 
            lblUpdateAuthor.AutoSize = true;
            lblUpdateAuthor.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblUpdateAuthor.Location = new Point(26, 90);
            lblUpdateAuthor.Name = "lblUpdateAuthor";
            lblUpdateAuthor.Size = new Size(63, 22);
            lblUpdateAuthor.TabIndex = 16;
            lblUpdateAuthor.Text = "Author";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(tbxUpdateAuthor);
            panel8.Location = new Point(120, 88);
            panel8.Name = "panel8";
            panel8.Size = new Size(178, 30);
            panel8.TabIndex = 31;
            // 
            // tbxUpdateAuthor
            // 
            tbxUpdateAuthor.BackColor = Color.White;
            tbxUpdateAuthor.BorderStyle = BorderStyle.None;
            tbxUpdateAuthor.Font = new Font("Microsoft Sans Serif", 7.8F);
            tbxUpdateAuthor.Location = new Point(3, 6);
            tbxUpdateAuthor.Name = "tbxUpdateAuthor";
            tbxUpdateAuthor.Size = new Size(169, 15);
            tbxUpdateAuthor.TabIndex = 5;
            // 
            // lblUpdateStock
            // 
            lblUpdateStock.AutoSize = true;
            lblUpdateStock.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblUpdateStock.Location = new Point(26, 174);
            lblUpdateStock.Name = "lblUpdateStock";
            lblUpdateStock.Size = new Size(60, 22);
            lblUpdateStock.TabIndex = 15;
            lblUpdateStock.Text = "Stock:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(tbxUpdateName);
            panel7.Location = new Point(120, 48);
            panel7.Name = "panel7";
            panel7.Size = new Size(178, 30);
            panel7.TabIndex = 30;
            // 
            // tbxUpdateName
            // 
            tbxUpdateName.BackColor = Color.White;
            tbxUpdateName.BorderStyle = BorderStyle.None;
            tbxUpdateName.Font = new Font("Microsoft Sans Serif", 7.8F);
            tbxUpdateName.Location = new Point(3, 6);
            tbxUpdateName.Name = "tbxUpdateName";
            tbxUpdateName.Size = new Size(171, 15);
            tbxUpdateName.TabIndex = 4;
            // 
            // lblUpdateName
            // 
            lblUpdateName.AutoSize = true;
            lblUpdateName.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblUpdateName.Location = new Point(26, 50);
            lblUpdateName.Name = "lblUpdateName";
            lblUpdateName.Size = new Size(62, 22);
            lblUpdateName.TabIndex = 0;
            lblUpdateName.Text = "Name:";
            // 
            // btnSearchBookName
            // 
            btnSearchBookName.BackColor = Color.CornflowerBlue;
            btnSearchBookName.Dock = DockStyle.Right;
            btnSearchBookName.FlatStyle = FlatStyle.Flat;
            btnSearchBookName.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold);
            btnSearchBookName.Image = (Image)resources.GetObject("btnSearchBookName.Image");
            btnSearchBookName.Location = new Point(357, 0);
            btnSearchBookName.Name = "btnSearchBookName";
            btnSearchBookName.Size = new Size(36, 34);
            btnSearchBookName.TabIndex = 27;
            btnSearchBookName.UseVisualStyleBackColor = false;
            btnSearchBookName.Click += btnSearchBookName_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSearchBookName);
            panel1.Controls.Add(tbxSearchBookName);
            panel1.Location = new Point(100, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 36);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSearchAuthor);
            panel2.Controls.Add(tbxSearchAuthor);
            panel2.Location = new Point(505, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 36);
            panel2.TabIndex = 28;
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.BackColor = Color.CornflowerBlue;
            btnSearchAuthor.Dock = DockStyle.Right;
            btnSearchAuthor.FlatStyle = FlatStyle.Flat;
            btnSearchAuthor.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold);
            btnSearchAuthor.Image = (Image)resources.GetObject("btnSearchAuthor.Image");
            btnSearchAuthor.Location = new Point(357, 0);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(36, 34);
            btnSearchAuthor.TabIndex = 27;
            btnSearchAuthor.UseVisualStyleBackColor = false;
            btnSearchAuthor.Click += btnSearchAuthor_Click;
            // 
            // ManageBooksMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 210, 245);
            ClientSize = new Size(982, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(gbUpdate);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(gbAdd);
            Controls.Add(btnDelete);
            Controls.Add(dgvBooks);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ManageBooksMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageBooksMenu";
            Load += ManageBooksMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAddStock).EndInit();
            gbAdd.ResumeLayout(false);
            gbAdd.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeUpdateStock).EndInit();
            gbUpdate.ResumeLayout(false);
            gbUpdate.PerformLayout();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numUpdateStock).EndInit();
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbxSearchBookName;
        private TextBox tbxSearchAuthor;
        private TextBox tbxAddName;
        private TextBox tbxAddAuthor;
        private DataGridView dgvBooks;
        private Button btnDelete;
        private ComboBox cmbAddCatagory;
        private NumericUpDown numAddStock;
        private GroupBox gbAdd;
        private Label lblAddName;
        private Label lblAddStock;
        private Label lblUpdateAuthor;
        private Label lblUpdateCatagory;
        private Button btnAdd;
        private Button btnUpdate;
        private GroupBox gbUpdate;
        private Label lblUpdateName;
        private NumericUpDown numeUpdateStock;
        private Label lblAddCatagory;
        private Label lblAddAuthor;
        private Label lblUpdateStock;
        private TextBox tbxUpdateName;
        private TextBox tbxUpdateAuthor;
        private NumericUpDown numUpdateStock;
        private ComboBox cbxUpdateCatagory;
        private Button btnSearchBookName;
        private Panel panel1;
        private Panel panel2;
        private Button btnSearchAuthor;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
    }
}