using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using BaseDeConhecimento.Authorization.Users;

namespace BaseDeConhecimento.Articles
{
    public class Article : Entity<int>, IFullAudited<User>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }  
        public string Body { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public bool IsFavorited { get; set; }
        public User CreatorUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public User LastModifierUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long? CreatorUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long? LastModifierUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? LastModificationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public User DeleterUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long? DeleterUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DeletionTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
