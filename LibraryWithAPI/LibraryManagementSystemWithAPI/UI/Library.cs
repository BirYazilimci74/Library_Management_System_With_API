
using LibraryManagementSystemWithAPI.API;

namespace LibraryManagementSystemWithAPI.UI
{
    public partial class Library : Form
    {
        private readonly BookOperations _bookOperations;
        private readonly BorrowedBookOperations _borrowedBookOperations;
        private readonly CategoryOperations _categoryOperations;
        public Library(BookOperations bookOperations,BorrowedBookOperations borrowedBookOperations, CategoryOperations categoryOperations)
        {
            InitializeComponent();
            _bookOperations = bookOperations;
            _borrowedBookOperations = borrowedBookOperations;
            _categoryOperations = categoryOperations;
        }

        private void btnBorrowMenu_Click(object sender, EventArgs e)
        {
            BorrowBookMenu borrowBookMenu = new BorrowBookMenu(_bookOperations,_borrowedBookOperations);
            borrowBookMenu.Show();
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            ReturnBookMenu returnBookMenu = new ReturnBookMenu(_borrowedBookOperations,_bookOperations);
            returnBookMenu.Show();
        }

        private void btnManageBooksMenu_Click(object sender, EventArgs e)
        {
            ManageBooksMenu manageBooksMenu = new ManageBooksMenu(_bookOperations,_categoryOperations);
            manageBooksMenu.Show();
        }

        private void Library_Load(object sender, EventArgs e)
        {

        }
    }
}
