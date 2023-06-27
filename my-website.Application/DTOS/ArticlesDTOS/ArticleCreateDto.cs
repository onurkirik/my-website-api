using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.DTOS.ArticlesDTOS
{
    public class ArticleCreateDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UserId { get; set; }
        public Guid CategoryId { get; set; }
    }
}
