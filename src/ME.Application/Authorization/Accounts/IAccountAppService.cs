using System.Threading.Tasks;
using Abp.Application.Services;
using ME.Authorization.Accounts.Dto;

namespace ME.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
