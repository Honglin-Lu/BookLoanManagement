using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookLoanManagement.Server.Data;
using BookLoanManagement.Shared.Domain;
using BookLoanManagement.Server.IRepository;

namespace BookLoanManagement.Server.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BooksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET:/Books
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var includes = new List<string> { "Author", "Publisher", "Category" };
            var books = await _unitOfWork.Books.GetAll(includes : includes);
            return Ok(books);
        }

        // GET:/Books/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            var includes = new List<string> { "Author", "Publisher", "Category", "Loans" };
            var book = await _unitOfWork.Books.Get(q => q.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        // PUT: /Books/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Books.Update(book);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Books
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            await _unitOfWork.Books.Insert(book);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBook", new { id = book.Id }, book);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _unitOfWork.Books.Get(q => q.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            await _unitOfWork.Books.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> BookExists(int id)
        {
            var book = await _unitOfWork.Books.Get(q => q.Id == id);
            return book == null;
        }
    }
}
