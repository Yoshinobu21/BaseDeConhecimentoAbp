using System.Threading.Tasks;
using Abp.Application.Services;
using BaseDeConhecimento.Authorization.Accounts.Dto;

namespace BaseDeConhecimento.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
