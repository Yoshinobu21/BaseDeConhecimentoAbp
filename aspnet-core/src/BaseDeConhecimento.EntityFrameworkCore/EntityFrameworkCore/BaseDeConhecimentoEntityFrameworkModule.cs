using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using BaseDeConhecimento.EntityFrameworkCore.Seed;

namespace BaseDeConhecimento.EntityFrameworkCore
{
    [DependsOn(
        typeof(BaseDeConhecimentoCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class BaseDeConhecimentoEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<BaseDeConhecimentoDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        BaseDeConhecimentoDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        BaseDeConhecimentoDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BaseDeConhecimentoEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
