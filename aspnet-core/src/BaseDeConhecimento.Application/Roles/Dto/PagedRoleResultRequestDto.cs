using Abp.Application.Services.Dto;

namespace BaseDeConhecimento.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

