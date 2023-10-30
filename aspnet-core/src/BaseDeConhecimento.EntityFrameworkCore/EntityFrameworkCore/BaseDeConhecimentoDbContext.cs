using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BaseDeConhecimento.Authorization.Roles;
using BaseDeConhecimento.Authorization.Users;
using BaseDeConhecimento.MultiTenancy;
using BaseDeConhecimento.Articles;

namespace BaseDeConhecimento.EntityFrameworkCore
{
    public class BaseDeConhecimentoDbContext : AbpZeroDbContext<Tenant, Role, User, BaseDeConhecimentoDbContext>
    {

        /* Define a DbSet for each entity of the application */
        public DbSet<Article> Articles { get; set; }
        
        public BaseDeConhecimentoDbContext(DbContextOptions<BaseDeConhecimentoDbContext> options)
            : base(options)
        {
        }
    }
}
