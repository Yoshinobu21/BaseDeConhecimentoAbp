using Abp.Application.Services;
using BaseDeConhecimento.MultiTenancy.Dto;

namespace BaseDeConhecimento.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

