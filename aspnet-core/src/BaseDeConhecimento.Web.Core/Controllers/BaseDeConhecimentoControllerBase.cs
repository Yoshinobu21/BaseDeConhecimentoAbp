using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BaseDeConhecimento.Controllers
{
    public abstract class BaseDeConhecimentoControllerBase: AbpController
    {
        protected BaseDeConhecimentoControllerBase()
        {
            LocalizationSourceName = BaseDeConhecimentoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
