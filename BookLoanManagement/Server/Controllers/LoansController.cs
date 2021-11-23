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
    public class LoansController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoansController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET:/Loans
        [HttpGet]
        public async Task<IActionResult> GetLoans()
        {
            var includes = new List<string> { "Book", "Customer" };
            var loans = await _unitOfWork.Loans.GetAll(includes : includes);
            return Ok(loans);
        }

        // GET:/Loans/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLoan(int id)
        {
            var includes = new List<string> { "Book", "Customer" };
            var loan = await _unitOfWork.Loans.Get(q => q.Id == id);

            if (loan == null)
            {
                return NotFound();
            }

            return Ok(loan);
        }

        // PUT: /Loans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoan(int id, Loan loan)
        {
            if (id != loan.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Loans.Update(loan);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await LoanExists(id))
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

        // POST: api/Loans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Loan>> PostLoan(Loan loan)
        {
            await _unitOfWork.Loans.Insert(loan);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetLoan", new { id = loan.Id }, loan);
        }

        // DELETE: api/Loans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoan(int id)
        {
            var loan = await _unitOfWork.Loans.Get(q => q.Id == id);
            if (loan == null)
            {
                return NotFound();
            }
            await _unitOfWork.Loans.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> LoanExists(int id)
        {
            var loan = await _unitOfWork.Loans.Get(q => q.Id == id);
            return loan == null;
        }
    }
}
