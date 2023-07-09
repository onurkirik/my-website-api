using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using my_website.Application.DTOS.ArticlesDTOS;
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
        private readonly IMapper _mapper;

        public ArticlesController(IArticleWriteRepository articleWriteRepository, IArticleReadRepository articleReadRepository, IMapper mapper)
        {
            _articleWriteRepository = articleWriteRepository;
            _articleReadRepository = articleReadRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> Get()
        {
            var data = _articleReadRepository.GetAll(false);
            return Ok(data);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var data = await _articleReadRepository.GetByIdAsync(id, false);
            return Ok(data);
        }

        [HttpPost]
        [Route("create-article")]
        public async Task<IActionResult> Create([FromBody] ArticleCreateDto model)
        {
            var entity = _mapper.Map<Article>(model);
            var result = await _articleWriteRepository.AddAsync(entity);

            return Ok(result);
        }

        [HttpPut]
        [Route("update-article")]
        public async Task<IActionResult> Update([FromBody] ArticleUpdateDto model)
        {
            var entity = _mapper.Map<Article>(model);

            var isUpdate = await _articleWriteRepository.UpdateAsync(entity);
            return Ok(isUpdate);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await _articleWriteRepository.RemoveAsync(id);

            return Ok(new
            {
                result,
                id
            });
        }
    }
}
