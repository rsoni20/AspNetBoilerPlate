using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ME.Roles.Dto;
using ME.Users.Dto;

namespace ME.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}