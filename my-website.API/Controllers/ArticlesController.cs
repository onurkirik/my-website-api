using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using my_website.Application.Repositories.ArticleRepository;
using my_website.Persistance.Context;

namespace my_website.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleReadRepository _articleReadRepository;
        private readonly IArticleWriteRepository _articleWriteRepository;
        private readonly ApplicationDbContext _context;

        public ArticlesController(IArticleWriteRepository articleWriteRepository, IArticleReadRepository articleReadRepository, ApplicationDbContext context)
        {
            _articleWriteRepository = articleWriteRepository;
            _articleReadRepository = articleReadRepository;
            _context = context;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> Get()
        {
            return Ok(_articleReadRepository.GetAll(false));
        }
    }
}
