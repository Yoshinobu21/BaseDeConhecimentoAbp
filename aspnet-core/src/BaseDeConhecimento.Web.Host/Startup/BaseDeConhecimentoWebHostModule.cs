using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BaseDeConhecimento.Configuration;

namespace BaseDeConhecimento.Web.Host.Startup
{
    [DependsOn(
       typeof(BaseDeConhecimentoWebCoreModule))]
    public class BaseDeConhecimentoWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BaseDeConhecimentoWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BaseDeConhecimentoWebHostModule).GetAssembly());
        }
    }
}
