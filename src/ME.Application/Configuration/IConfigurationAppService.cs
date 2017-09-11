using System.Threading.Tasks;
using ME.Configuration.Dto;

namespace ME.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}