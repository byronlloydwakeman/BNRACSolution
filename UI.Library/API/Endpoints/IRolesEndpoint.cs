using System.Threading.Tasks;
using UI.Library.Models;

namespace UI.Library.API.Endpoints
{
    public interface IRolesEndpoint
    {
        Task AddRole(UserRoleUIModel userRoleUIModel);
        Task RemoveRole(UserRoleUIModel userRoleUIModel);
    }
}