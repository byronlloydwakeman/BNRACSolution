using System.Threading.Tasks;

namespace UI.Library.API.Endpoints
{
    public interface IUserEndpoint
    {
        Task<string> GetUserId();
    }
}