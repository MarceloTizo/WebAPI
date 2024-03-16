using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ContatosController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] Contato contato)
    {
        return CreatedAtAction(nameof(Get), new { id = 1 }, contato); 
    }

    [HttpGet("{id}")]
    public ActionResult<Contato> Get(int id)
    {
       
        return new Contato("NomeExemplo", "SobrenomeExemplo", "1234-5678", "exemplo@email.com");
    }
}
