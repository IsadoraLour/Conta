using Conta;
using Dominio._03_Service;
using Dominio._03_Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaCorrenteController : ControllerBase
    {
        
            private readonly ContaCorrenteService _service;

            public ContaCorrenteController(IConfiguration config, ContaCorrenteService contaCorrenteService)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _service = contaCorrenteService;
            }

            [HttpPost("adicionar-Caminhao")]
            public void AdicionarCaminhao(ContaCorrente contaCorrente)
            {
                _service.Adicionar(contaCorrente);
            }

            [HttpGet("listar-Caminhao")]
            public List<ContaCorrente> ListarCaminhao()
            {
                return _service.Listar();
            }

            [HttpPut("editar-Caminhao")]
            public void EditarCaminhao(ContaCorrente contaCorrente)
            {
                _service.Editar(contaCorrente);
            }

            [HttpDelete("deletar-Caminhao")]
            public void DeletarCaminhao(int id)
            {
                _service.Remover(id);
            }
        
    }
}
