using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeConhecimento.Articles
{
    [AutoMapFrom(typeof(Article))]
    public class ArticleDto : EntityDto<int>, IHasCreationTime, IHasModificationTime, IHasDeletionTime, ISoftDelete
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string body { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public bool IsFavorited { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public bool IsDeleted { get; set; }

    }
}
