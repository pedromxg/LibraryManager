using GerenciadorBiblioteca.API.Models.InputModels;
using GerenciadorBiblioteca.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorBiblioteca.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _bookService.GetAll();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = _bookService.GetById(id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public IActionResult Create([FromBody] BookInputModel bookInputModel) 
        {
            var newBook = _bookService.Create(bookInputModel);

            if (newBook == null)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new { id = newBook.Id }, newBook); 
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] BookInputModel updateBookInputModel)
        {
            var updatedBook = _bookService.Update(id, updateBookInputModel);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookService.Delete(id);

            return NoContent();
        }
    }
}
