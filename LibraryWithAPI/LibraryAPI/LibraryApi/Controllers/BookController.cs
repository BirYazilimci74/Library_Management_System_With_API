using LibraryApi.DTOs.Book;
using LibraryApi.Interfaces;
using LibraryApi.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var books = await _bookRepository.GetAllAsync();
            var booksDto = books;
            //.Select(b => b.ToBookResponseDTO());
            
            return Ok(booksDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute]int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);

            if (book is null)
            {
                return NotFound();
            }
            return Ok(book/*.ToBookResponseDTO()*/);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute]int id)
        {
            var bookToDelete = await _bookRepository.DeleteAsync(id);

            if (bookToDelete is null)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody]BookDTO book)
        {
            if (book is not null)
            {
                await _bookRepository.AddAsync(book);
                return CreatedAtAction(nameof(GetByIdAsync), new { id = book.ToBook().Id }, book);
            }
            return BadRequest("Book coulldn't added!!!");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync([FromRoute]int id,[FromBody]BookDTO book)
        {
            await _bookRepository.UpdateAsync(id, book);

            return Ok(book.ToBook());
        }
    }
}