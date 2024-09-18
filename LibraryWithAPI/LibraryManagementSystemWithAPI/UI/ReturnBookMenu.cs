using LibraryManagementSystemWithAPI.API;
using LibraryManagementSystemWithAPI.DTOs.Book;
using LibraryManagementSystemWithAPI.Mappers;

namespace LibraryManagementSystemWithAPI.UI
{
    public partial class ReturnBookMenu : Form
    {
        private readonly BorrowedBookOperations _borrowedBookOperations;
        private readonly BookOperations _bookOperations;
        public ReturnBookMenu(BorrowedBookOperations borrowedBookOperations, BookOperations bookOperations)
        {
            InitializeComponent();
            _borrowedBookOperations = borrowedBookOperations;
            _bookOperations = bookOperations;
        }

        private async void ReturnBookMenu_Load(object sender, EventArgs e)
        {
            await LoadBorrowedBooksAsync();
        }

        private async Task LoadBorrowedBooksAsync()
        {
            var borrowedBooks = await _borrowedBookOperations.GetAllAsync();
            var borrowedBookDto = borrowedBooks
                .Select(bb => bb.ToBorrowedBookDTO())
                .Select(bb => new
                {
                    bb.Id,
                    bb.Book?.Name,
                    bb.BorrewedTime,
                    bb.ReturnTime
                })
                .ToList();

            dgvBorrowedBooks.DataSource = borrowedBookDto;

            if (dgvBorrowedBooks.Columns.Contains("Id"))
            {
                dgvBorrowedBooks.Columns["Id"].Visible = false;
            }
        }

        private int DetermineSelectedBorrowedBookId()
        {
            int selectedRow = dgvBorrowedBooks.SelectedRows[0].Index;
            int selectedBorrowedBookId = Convert.ToInt32(dgvBorrowedBooks.Rows[selectedRow].Cells[0].Value);
            return selectedBorrowedBookId;
        }

        private async void btnReturn_Click(object sender, EventArgs e)
        {
            await ReturnSelectedBook();
            MessageBox.Show("The book has been successfully returned.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadBorrowedBooksAsync();
        }

        private async Task ReturnSelectedBook()
        {
            try
            {
                int selectedBorrowedBookId = DetermineSelectedBorrowedBookId();

                var borrowedBookToReturn = await _borrowedBookOperations.GetByIdAsync(selectedBorrowedBookId);
                var book = await _bookOperations.GetByIdAsync(borrowedBookToReturn.BookID);

                await _bookOperations.UpdateAsync(book.Id, new BookDTO()
                {
                    Name = book.Name,
                    Author = book.Author,
                    Stock = ++book.Stock,
                    CategoryId = book.CategoryId,
                });

                await _borrowedBookOperations.DeleteBorrowedBookByIdAsync(selectedBorrowedBookId);
            }
            catch
            {
                MessageBox.Show("The Book Couldn't Returned!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private async void btnOverdue_Click(object sender, EventArgs e)
        {
            await ListOverdueBooksAsync();
        }

        private async Task ListOverdueBooksAsync()
        {
            var borrowedBooks = await _borrowedBookOperations.GetAllAsync();
            var overdueBooks = borrowedBooks
                .Select(bb => bb.ToBorrowedBookDTO())
                .Select(bb => new
                {
                    bb.Id,
                    bb.Book?.Name,
                    bb.BorrewedTime,
                    bb.ReturnTime
                })
                .Where(bb => bb.ReturnTime < DateTime.Now)
                .ToList();
            dgvBorrowedBooks.DataSource = overdueBooks;
        }

        private async Task SearchByBookName()
        {
            string? searchString = String.IsNullOrWhiteSpace(tbxSearchBookName.Text) ? null : tbxSearchBookName.Text.ToLower();

            if (searchString is not null)
            {
                var bbBooks = await _borrowedBookOperations.GetAllAsync();
                var bbBooksWithFilter = bbBooks
                    .Select(bb => bb.ToBorrowedBookDTO())
                    .Select(bb => new
                    {
                        bb.Id,
                        bb.Book?.Name,
                        bb.BorrewedTime,
                        bb.ReturnTime
                    })
                    .Where(book => book.Name.ToLower().Contains(searchString)).ToList();
                dgvBorrowedBooks.DataSource = bbBooksWithFilter;
                return;
            }
            await LoadBorrowedBooksAsync();
        }

        private async void btnSearchBookName_Click(object sender, EventArgs e)
        {
            await SearchByBookName();
        }
    }
}
