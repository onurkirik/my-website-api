using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using my_website.Application.Repositories.ArticleRepository;
using my_website.Domain.Entities;
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
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await _articleReadRepository.GetByIdAsync(id, false));
        }

        [HttpPut]
        [Route("update-article")]
        public IActionResult Update([FromBody] Article model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedArticle =  _articleWriteRepository.UpdateAsync(model);
            return Ok(updatedArticle);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            return Ok(await _articleWriteRepository.RemoveAsync(id));
        }
    }
}
