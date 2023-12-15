using GerenciadorBiblioteca.API.Models.InputModels;
using GerenciadorBiblioteca.API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorBiblioteca.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create([FromBody] UserInputModel userInputModel)
        {
            var newUser = _userService.Create(userInputModel);

            if (newUser == null)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new { id = newUser.Id }, newUser);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UserInputModel updateBookInputModel)
        {
            _userService.Update(id, updateBookInputModel);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);

            return NoContent();
        }
    }
}
