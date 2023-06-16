using my_website.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Domain.Entities
{
    public class Education : BaseEntity
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Navigation Properties
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
