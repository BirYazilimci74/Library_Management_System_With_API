using LibraryApi.Contexts;
using LibraryApi.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers
{
    [Route("api/catagory")]
    [ApiController]
    public class CatagoryController : ControllerBase
    {
        private readonly LibraryDBContext _context;

        public CatagoryController(LibraryDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var catagories = _context.Categories.ToList();
            //.Select(c => c.ToCatagoryDTO());
            return Ok(catagories);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var catagory = _context.Categories.Find(id);
            
            if (catagory is null)
            {
                return NotFound();
            }

            return Ok(catagory/*.ToCatagoryDTO()*/);
        }
    }
}