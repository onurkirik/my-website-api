using my_website.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Domain.Entities
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        //Navigation Properties
        public Guid? UserId { get; set; }
        public AppUser Author { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
