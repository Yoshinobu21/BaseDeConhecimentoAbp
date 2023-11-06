using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using BaseDeConhecimento.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeConhecimento.Articles
{
    [AbpAuthorize(PermissionNames.Pages_Articles)]
    public class ArticlesAppService : CrudAppService<Article, ArticleDto>
    {
        public ArticlesAppService(IRepository<Article, int> repository) : base(repository)
        {
        }
    }
}