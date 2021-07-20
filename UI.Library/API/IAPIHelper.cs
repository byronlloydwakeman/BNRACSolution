using System.Net.Http;
using System.Threading.Tasks;

namespace UI.Library.API
{
    public interface IAPIHelper
    {
        HttpClient apiClient { get; set; }
        Task Login(string username, string password);
    }
}