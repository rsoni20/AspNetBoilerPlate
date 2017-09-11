using System.Threading.Tasks;
using Abp.Application.Services;
using ME.Sessions.Dto;

namespace ME.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
