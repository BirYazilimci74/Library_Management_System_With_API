using LibraryApi.Contexts;
using LibraryApi.DTOs.BorrowedBook;
using LibraryApi.Interfaces;
using LibraryApi.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers
{
    [Route("api/borrowedbook")]
    [ApiController]
    public class BorrowedBookController : ControllerBase
    {
        private readonly IBorrowedBookRepository _borrowedBookRepository;
        public BorrowedBookController(IBorrowedBookRepository borrowedBookRepository)
        {
            _borrowedBookRepository = borrowedBookRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var borrowedBooks = await _borrowedBookRepository.GetAllAsync();
            var borrowedBooksDto = borrowedBooks;
            //.Select(bb => bb.ToBorrowedBookResponseDTO());
            
            return Ok(borrowedBooksDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute]int id)
        {
            var borrowedBook = await _borrowedBookRepository.GetByIdAsync(id);
            
            if (borrowedBook is null)
            {
                return NotFound();
            }
            return Ok(borrowedBook/*.ToBorrowedBookResponseDTO()*/);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute]int id)
        {
            var borrowedBookToDelete = await _borrowedBookRepository.DeleteAsync(id);

            if (borrowedBookToDelete is null)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody]BorrowedBookDTO borrowedBook)
        {
            if (borrowedBook is not null)
            {
                await _borrowedBookRepository.AddAsync(borrowedBook);
                return Ok();
            }
            return BadRequest("Book couldn't borrowed");
            
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync([FromRoute]int id,[FromBody]BorrowedBookDTO borrowedBook)
        {
            await _borrowedBookRepository.UpdateAsync(id, borrowedBook);
            
            return Ok();
        }
    }
}