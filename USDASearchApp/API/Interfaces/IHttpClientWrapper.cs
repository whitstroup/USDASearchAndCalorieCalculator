using System.Threading.Tasks;

namespace USDASearchApp.API.Interfaces
{
    public interface IHttpClientWrapper
    {
        Task<string> GetAsync(string uri);
        Task<string> PostAsync(string uri);
    }
}
