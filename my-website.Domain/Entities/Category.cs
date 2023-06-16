using my_website.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        //Navigaton Property
        public ICollection<Article> Articles { get; set; }
    }
}
