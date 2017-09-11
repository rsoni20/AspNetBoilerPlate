using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ME.Configuration.Dto;

namespace ME.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MEAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
