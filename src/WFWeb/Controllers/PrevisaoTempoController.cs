using WFDomain.Models;
using WFDomain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WFWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrevisaoTempoController : ControllerBase
    {
        private readonly IPrevisaoTempoService _previsaoTempoService;

        public PrevisaoTempoController(IPrevisaoTempoService previsaoTempoService)
        {
            _previsaoTempoService = previsaoTempoService ??
                throw new ArgumentNullException(nameof(previsaoTempoService));
        }

        [HttpGet]
        [Route("nomecidade/{nomeCidade}")]
        public Task<ICollection<Cidade>> GetCidades(string nomeCidade)
        {
            return _previsaoTempoService.GetCidades(nomeCidade);
        }

        [HttpGet]
        [Route("nomecidade")]
        public Task<ICollection<Cidade>> GetCidades()
        {
            
            return _previsaoTempoService.GetCidades(string.Empty);
        }

        [HttpGet]
        [Route("{idCidade}")]
        public Task<PrevisaoCidade> GetPrevisao7Dias(int idCidade)
        {
            return _previsaoTempoService.GetPrevisao7Dias(idCidade);
        }
    }
}
