using Microsoft.AspNetCore.Mvc;
using TarefasBack.Models;
using TarefasBack.Repositories;

namespace TarefasBack.Controllers
{
    //Rota//
    [Route("tarefas")]
    [ApiController]

    public class TarefaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Read([FromServices] ITarefaRepositories repositories)
        {

            var tarefas = repositories.Read();
            return Ok(tarefas);
        }

        [HttpPost]

        public IActionResult Create([FromBody] Tarefa model, [FromServices] ITarefaRepositories repositories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            repositories.Create(model);

            return Ok();






        }




    }
}