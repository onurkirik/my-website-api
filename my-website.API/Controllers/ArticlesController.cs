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

        public ArticlesController(IArticleWriteRepository articleWriteRepository, IArticleReadRepository articleReadRepository)
        {
            _articleWriteRepository = articleWriteRepository;
            _articleReadRepository = articleReadRepository;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> Get()
        {
            return Ok(_articleReadRepository.GetAll(false));
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            return Ok(await _articleReadRepository.GetByIdAsync(id, false));
        }
    }
}
