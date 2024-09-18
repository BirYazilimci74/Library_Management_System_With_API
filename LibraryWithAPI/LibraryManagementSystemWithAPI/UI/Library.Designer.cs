namespace LibraryManagementSystemWithAPI.UI
{
    partial class Library
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
            btnBorrowMenu = new Button();
            btnReturnMenu = new Button();
            btnManageBooksMenu = new Button();
            SuspendLayout();
            // 
            // btnBorrowMenu
            // 
            btnBorrowMenu.BackColor = Color.CornflowerBlue;
            btnBorrowMenu.FlatStyle = FlatStyle.Flat;
            btnBorrowMenu.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            btnBorrowMenu.Location = new Point(195, 100);
            btnBorrowMenu.Margin = new Padding(3, 2, 3, 2);
            btnBorrowMenu.Name = "btnBorrowMenu";
            btnBorrowMenu.Size = new Size(160, 64);
            btnBorrowMenu.TabIndex = 0;
            btnBorrowMenu.Text = "Borrow";
            btnBorrowMenu.UseVisualStyleBackColor = false;
            btnBorrowMenu.Click += btnBorrowMenu_Click;
            // 
            // btnReturnMenu
            // 
            btnReturnMenu.BackColor = Color.CornflowerBlue;
            btnReturnMenu.FlatStyle = FlatStyle.Flat;
            btnReturnMenu.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            btnReturnMenu.Location = new Point(195, 200);
            btnReturnMenu.Margin = new Padding(3, 2, 3, 2);
            btnReturnMenu.Name = "btnReturnMenu";
            btnReturnMenu.Size = new Size(160, 64);
            btnReturnMenu.TabIndex = 1;
            btnReturnMenu.Text = "Return";
            btnReturnMenu.UseVisualStyleBackColor = false;
            btnReturnMenu.Click += btnReturnMenu_Click;
            // 
            // btnManageBooksMenu
            // 
            btnManageBooksMenu.BackColor = Color.CornflowerBlue;
            btnManageBooksMenu.FlatStyle = FlatStyle.Flat;
            btnManageBooksMenu.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            btnManageBooksMenu.Location = new Point(195, 300);
            btnManageBooksMenu.Margin = new Padding(3, 2, 3, 2);
            btnManageBooksMenu.Name = "btnManageBooksMenu";
            btnManageBooksMenu.Size = new Size(160, 64);
            btnManageBooksMenu.TabIndex = 2;
            btnManageBooksMenu.Text = "Manage Books";
            btnManageBooksMenu.UseVisualStyleBackColor = false;
            btnManageBooksMenu.Click += btnManageBooksMenu_Click;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 210, 245);
            ClientSize = new Size(532, 503);
            Controls.Add(btnManageBooksMenu);
            Controls.Add(btnReturnMenu);
            Controls.Add(btnBorrowMenu);
            Font = new Font("Microsoft Sans Serif", 7.8F);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Library";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library";
            Load += Library_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBorrowMenu;
        private Button btnReturnMenu;
        private Button btnManageBooksMenu;
    }
}