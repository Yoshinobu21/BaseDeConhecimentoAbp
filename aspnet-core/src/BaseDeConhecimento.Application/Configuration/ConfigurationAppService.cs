using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BaseDeConhecimento.Configuration.Dto;

namespace BaseDeConhecimento.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BaseDeConhecimentoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
