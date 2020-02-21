using WFDomain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace WFDomain.Services
{
    public class PrevisaoTempoService : IPrevisaoTempoService
    {
        private readonly List<CondicaoTempo> _condicoesTempo;
        private readonly IWebReaderService _webReaderService;

        public PrevisaoTempoService(List<CondicaoTempo> condicoesTempo,
            IWebReaderService webReaderService)
        {
            _condicoesTempo = condicoesTempo ?? 
                throw new ArgumentNullException(nameof(condicoesTempo));
            _webReaderService = webReaderService ??
                throw new ArgumentNullException(nameof(webReaderService));
        }

        public async Task<ICollection<Cidade>> GetCidades(string nomeCidade)
        {
            var URI = $"http://servicos.cptec.inpe.br/XML/listaCidades?city={nomeCidade?.Trim()}";
            var cidades = await _webReaderService.ReadUriAsync<Cidades>(URI);
            return cidades?.ListaCidade;
        }

        public async Task<PrevisaoCidade> GetPrevisao7Dias(int idCidade)
        {
            var URI = $"http://servicos.cptec.inpe.br/XML/cidade/7dias/{idCidade}/previsao.xml";
            var previsaoCidade = await _webReaderService.ReadUriAsync<PrevisaoCidade>(URI);
            previsaoCidade.Previsoes.ForEach(previsao =>
                previsao.CondicaoTempo =
                    _condicoesTempo.FirstOrDefault
                        (ct => ct.Sigla.Equals(previsao.Tempo?.Trim())));
            return previsaoCidade;
        }
    }
}
