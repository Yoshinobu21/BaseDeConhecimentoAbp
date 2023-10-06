using System.Threading.Tasks;
using BaseDeConhecimento.Configuration.Dto;

namespace BaseDeConhecimento.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
