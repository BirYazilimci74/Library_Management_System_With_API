using LibraryManagementSystemWithAPI.APIOperations;
using LibraryManagementSystemWithAPI.DTOs.Book;
using LibraryManagementSystemWithAPI.FluentValidation;
using LibraryManagementSystemWithAPI.Mappers;
using LibraryManagementSystemWithAPI.Models;

namespace LibraryManagementSystemWithAPI.UI
{
    public partial class ManageBooksMenu : Form
    {
        private readonly BookOperations _bookOperations;
        private readonly CategoryOperations _categoryOperations;
        public ManageBooksMenu(BookOperations bookOperations, CategoryOperations categoryOperations)
        {
            InitializeComponent();
            _bookOperations = bookOperations;
            _categoryOperations = categoryOperations;
        }

        private async void ManageBooksMenu_Load(object sender, EventArgs e)
        {
            await LoadBooksAsync();
            await LoadCategoryAsync(cbxUpdateCatagory);
            await LoadCategoryAsync(cmbAddCatagory);
        }

        private async Task LoadBooksAsync()
        {
            var books = await _bookOperations.GetAllAsync();
            dgvBooks.DataSource = books.Select(b => b.ToBookResponseDTO()).ToList();

            if (dgvBooks.Columns.Contains("Id"))
            {
                dgvBooks.Columns["Id"].Visible = false;
            }
        }

        private async Task LoadCategoryAsync(ComboBox comboBox)
        {
            try
            {
                var categories = await _categoryOperations.GetAllAsync();
                var categoryNames = categories.Select(c => c.Name).ToList();
                comboBox.DataSource = categoryNames;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        private void ClearTextBoxes()
        {
            tbxAddName.Clear();
            tbxAddAuthor.Clear();
            tbxUpdateName.Clear();
            tbxUpdateAuthor.Clear();
            numAddStock.Value = decimal.Zero;
            numUpdateStock.Value = decimal.Zero;
        }

        private void ClearErrors()
        {
            lblAddNameError.Text = string.Empty;
            lblAddAuthorError.Text = string.Empty;
            lblUpdateNameError.Text = string.Empty;
            lblUpdateAuthorError.Text = string.Empty;
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedBooks = dgvBooks.Rows[e.RowIndex];
                tbxUpdateName.Text = selectedBooks.Cells[1].Value.ToString();
                tbxUpdateAuthor.Text = selectedBooks.Cells[2].Value.ToString();
                cbxUpdateCatagory.Text = selectedBooks.Cells[3].Value.ToString();
                numUpdateStock.Value = Convert.ToDecimal(selectedBooks.Cells[4].Value);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await DeleteSelectedBook();
            await LoadBooksAsync();
            ClearTextBoxes();
        }

        private async Task DeleteSelectedBook()
        {
            int selectedBookId = Convert.ToInt32(dgvBooks.CurrentRow?.Cells[0].Value);
            await _bookOperations.DeleteById(selectedBookId);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            ClearErrors();
            await AddBookAsync();
            await LoadBooksAsync();
        }

        private async Task<int> GetCategoryIdByName(string categoryName)
        {
            var categories = await _categoryOperations.GetAllAsync();
            return categories.FirstOrDefault(c => c.Name == categoryName)?.Id ?? -1;
        }

        private async Task AddBookAsync()
        {
            string selectedCategoryName = cmbAddCatagory.Text;
            int selectedCategoryId = await GetCategoryIdByName(selectedCategoryName);

            if (selectedCategoryId == -1)
            {
                MessageBox.Show("The Book Couldn't Added!\nInvalid Catagory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Book newBook = new Book()
            {
                Name = tbxAddName.Text,
                Author = tbxAddAuthor.Text,
                CategoryId = selectedCategoryId,
                Stock = Convert.ToInt32(numAddStock.Value)
            };

            BookValidator validator = new BookValidator();
            var result = validator.Validate(newBook);

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    if (error.PropertyName == nameof(newBook.Name))
                    {
                        lblAddNameError.Text = error.ErrorMessage;
                    }

                    if (error.PropertyName == nameof(newBook.Author))
                    {
                        lblAddAuthorError.Text = error.ErrorMessage;
                    }

                    if (error.PropertyName == nameof(newBook.Stock))
                    {
                        lblAddStockError.Text = error.ErrorMessage;
                    }
                }

                return;
            }

            await _bookOperations.AddAsync(newBook.ToBookDTO());
            ClearTextBoxes();
        }

        private async Task UpdateSelectedBookAsync()
        {
            int selectedRow = dgvBooks.SelectedRows[0].Index;
            int selectedBookId = Convert.ToInt32(dgvBooks.Rows[selectedRow].Cells[0].Value);

            string selectedCategoryName = cbxUpdateCatagory.Text;
            int selectedCategoryId = await GetCategoryIdByName(selectedCategoryName);

            if (selectedCategoryId == -1)
            {
                MessageBox.Show("The Book Couldn't Added!\nInvalid Catagory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            var updatedBook = new BookDTO()
            {
                Name = tbxUpdateName.Text,
                Author = tbxUpdateAuthor.Text,
                CategoryId = selectedCategoryId,
                Stock = Convert.ToInt32(numUpdateStock.Value)
            };

            BookValidator validator = new BookValidator();
            var result = validator.Validate(updatedBook.ToBook());

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    if (error.PropertyName == nameof(updatedBook.Name))
                    {
                        lblUpdateNameError.Text = error.ErrorMessage;
                    }
                    
                    if (error.PropertyName == nameof(updatedBook.Author))
                    {
                        lblUpdateAuthorError.Text = error.ErrorMessage;
                    }

                    if (error.PropertyName == nameof(updatedBook.Stock))
                    {
                        lblUpdateStockError.Text = error.ErrorMessage;
                    }
                }

                return;
            }

            await _bookOperations.UpdateAsync(selectedBookId, updatedBook);
            await LoadBooksAsync();
            ClearTextBoxes();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            ClearErrors();
            await UpdateSelectedBookAsync();
        }

        private async Task SearchBooksByFilter(string searchString, Func<BookResponseDTO, string> filter)
        {
            var books = await _bookOperations.GetAllAsync();
            var booksWithFilter = books
                .Select(b => b.ToBookResponseDTO())
                .Where(book => filter(book).ToLower().Contains(searchString.ToLower()))
                .ToList();

            dgvBooks.DataSource = booksWithFilter;
        }

        private async void btnSearchBookName_Click(object sender, EventArgs e)
        {
            await SearchBooksByFilter(tbxSearchBookName.Text, b => b.Name);
        }

        private async void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            await SearchBooksByFilter(tbxSearchAuthor.Text, b => b.Author);
        }

    }
}
