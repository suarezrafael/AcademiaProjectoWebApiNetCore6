using AcademiaProjeto.Domain.Entities;
using AcademiaProjeto.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace AcademiaProjeto.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ICursoRepository _cursoRepository;

        public CursoController(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }
        [HttpPost]
        public async Task<IActionResult> Register(Curso curso) 
        {
            if(curso == null)
                return BadRequest($"{curso} não pode ser nulo");

            await _cursoRepository.CreateAsync(curso);
            return Ok("Curso cadastrado com sucesso.");
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = _cursoRepository.GetAll();
            if(result == null)
                return NotFound();

            return Ok(result.Result);
        }
    }
}
