using Conta;
using Dominio._03_Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaPoupancaController : ControllerBase
    {

        private readonly ContaPoupancaService _service;

        public ContaPoupancaController(IConfiguration config, ContaPoupancaService contaPoupancaService)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = contaPoupancaService;
        }

        [HttpPost("adicionar-Caminhao")]
        public void AdicionarCaminhao(ContaPoupanca contaPoupanca)
        {
            _service.Adicionar(contaPoupanca);
        }

        [HttpGet("listar-Caminhao")]
        public List<ContaPoupanca> ListarCaminhao()
        {
            return _service.Listar();
        }

        [HttpPut("editar-Caminhao")]
        public void EditarCaminhao(ContaPoupanca contaPoupanca)
        {
            _service.Editar(contaPoupanca);
        }

        [HttpDelete("deletar-Caminhao")]
        public void DeletarCaminhao(int id)
        {
            _service.Remover(id);
        }

    }
}

