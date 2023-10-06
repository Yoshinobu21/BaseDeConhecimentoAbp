using System.Threading.Tasks;
using Abp.Application.Services;
using BaseDeConhecimento.Sessions.Dto;

namespace BaseDeConhecimento.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
