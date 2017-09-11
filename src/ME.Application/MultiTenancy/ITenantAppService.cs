using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ME.MultiTenancy.Dto;

namespace ME.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
