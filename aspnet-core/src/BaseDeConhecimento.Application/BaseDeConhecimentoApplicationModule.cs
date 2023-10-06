using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BaseDeConhecimento.Authorization;

namespace BaseDeConhecimento
{
    [DependsOn(
        typeof(BaseDeConhecimentoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BaseDeConhecimentoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BaseDeConhecimentoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BaseDeConhecimentoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
