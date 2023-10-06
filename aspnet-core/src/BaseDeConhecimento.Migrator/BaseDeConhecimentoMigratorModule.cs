using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BaseDeConhecimento.Configuration;
using BaseDeConhecimento.EntityFrameworkCore;
using BaseDeConhecimento.Migrator.DependencyInjection;

namespace BaseDeConhecimento.Migrator
{
    [DependsOn(typeof(BaseDeConhecimentoEntityFrameworkModule))]
    public class BaseDeConhecimentoMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public BaseDeConhecimentoMigratorModule(BaseDeConhecimentoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(BaseDeConhecimentoMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                BaseDeConhecimentoConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BaseDeConhecimentoMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
