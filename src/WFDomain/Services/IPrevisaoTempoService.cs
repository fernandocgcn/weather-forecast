using WFDomain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WFDomain.Services
{
    public interface IPrevisaoTempoService
    {
        Task<ICollection<Cidade>> GetCidades(string nomeCidade);
        Task<PrevisaoCidade> GetPrevisao7Dias(int idCidade);
    }
}
