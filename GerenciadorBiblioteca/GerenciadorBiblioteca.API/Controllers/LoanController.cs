using GerenciadorBiblioteca.API.Models.InputModels;
using GerenciadorBiblioteca.API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorBiblioteca.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class LoanController : ControllerBase
    {
        private readonly ILoanService _loanService;

        public LoanController(ILoanService loanService)
        {
            _loanService = loanService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var loans = _loanService.GetAll();

            return Ok(loans);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var loan = _loanService.GetById(id);

            if (loan == null)
            {
                return NotFound();
            }

            return Ok(loan);
        }

        [HttpPost]
        public IActionResult Create([FromBody] LoanInputModel loanInputModel)
        {
            var newLoan = _loanService.Create(loanInputModel);

            if (newLoan == null)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new { id = newLoan.Id }, newLoan);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] LoanInputModel loanInputModel)
        {
            _loanService.Update(id, loanInputModel);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _loanService.Delete(id);

            return NoContent();
        }
    }
}
