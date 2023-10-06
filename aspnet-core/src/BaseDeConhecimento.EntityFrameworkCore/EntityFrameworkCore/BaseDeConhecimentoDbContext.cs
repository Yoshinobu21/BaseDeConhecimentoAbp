using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BaseDeConhecimento.Authorization.Roles;
using BaseDeConhecimento.Authorization.Users;
using BaseDeConhecimento.MultiTenancy;

namespace BaseDeConhecimento.EntityFrameworkCore
{
    public class BaseDeConhecimentoDbContext : AbpZeroDbContext<Tenant, Role, User, BaseDeConhecimentoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BaseDeConhecimentoDbContext(DbContextOptions<BaseDeConhecimentoDbContext> options)
            : base(options)
        {
        }
    }
}
