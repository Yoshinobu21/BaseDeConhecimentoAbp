using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BaseDeConhecimento.EntityFrameworkCore;
using BaseDeConhecimento.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace BaseDeConhecimento.Web.Tests
{
    [DependsOn(
        typeof(BaseDeConhecimentoWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BaseDeConhecimentoWebTestModule : AbpModule
    {
        public BaseDeConhecimentoWebTestModule(BaseDeConhecimentoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BaseDeConhecimentoWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BaseDeConhecimentoWebMvcModule).Assembly);
        }
    }
}