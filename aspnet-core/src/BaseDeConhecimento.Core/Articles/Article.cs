using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;

namespace BaseDeConhecimento.Articles
{
    public class Article : Entity<int>, IHasCreationTime, IHasModificationTime, IHasDeletionTime, ISoftDelete
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }  
        public string Body { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public bool IsFavorited { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public bool IsDeleted { get; set; }
    


    }
}
