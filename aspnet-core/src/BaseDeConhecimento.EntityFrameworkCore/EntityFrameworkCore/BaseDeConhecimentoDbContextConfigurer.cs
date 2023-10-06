using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BaseDeConhecimento.EntityFrameworkCore
{
    public static class BaseDeConhecimentoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BaseDeConhecimentoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BaseDeConhecimentoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
