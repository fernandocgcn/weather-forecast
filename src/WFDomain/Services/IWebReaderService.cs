using System.Threading.Tasks;

namespace WFDomain.Services
{
    public interface IWebReaderService
    {
        public Task<T> ReadUriAsync<T>(string URI);
    }
}
