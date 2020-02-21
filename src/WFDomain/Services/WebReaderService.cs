using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WFDomain.Services
{
    public class WebReaderService : IWebReaderService
    {
        public async Task<T> ReadUriAsync<T>(string URI)
        {
            using var httpClient = new HttpClient();
            var httpResponse = await httpClient.GetAsync(URI);
            T result;
            if (httpResponse.IsSuccessStatusCode)
            {
                var xmlStream = await httpResponse.Content.ReadAsStreamAsync();
                var xmlSerializer = new XmlSerializer(typeof(T));
                result = (T)xmlSerializer.Deserialize(xmlStream);
            }
            else
                throw new HttpRequestException(httpResponse.ReasonPhrase);
            return result;
        }
    }
}
