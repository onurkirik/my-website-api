using my_website.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Domain.Entities
{
    public class Certificate : BaseEntity
    {
        public string Name { get; set; }

        //Navigation Properties
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
