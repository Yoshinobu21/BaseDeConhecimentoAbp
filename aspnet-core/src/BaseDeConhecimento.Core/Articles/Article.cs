using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Abp.Domain.Entities;

namespace BaseDeConhecimento.Articles
{
    public class Article : Entity<int>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }  
        public string body { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public string favorited {  get; set; }
        

    }
}
