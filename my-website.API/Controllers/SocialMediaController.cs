using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_website.Application.DTOS.SocialMediaDTOS;
using my_website.Application.Repositories.SocialMediaRepository;
using my_website.Domain.Entities;

namespace my_website.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaReadRepository _socialMediaReadRepository;
        private readonly ISocialMediaWriteRepository _socialMediaWriteRepository;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaReadRepository socialMediaReadRepository, ISocialMediaWriteRepository socialMediaWriteRepository, IMapper mapper)
        {
            _socialMediaReadRepository = socialMediaReadRepository;
            _socialMediaWriteRepository = socialMediaWriteRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> Get()
        {
            var data = _socialMediaReadRepository.GetAll();
            return Ok(data);
        }

        [HttpPost]
        [Route("create-social-media")]
        public async Task<IActionResult> Create([FromBody] SocialMediaCreateDTO model)
        {
            var entity = _mapper.Map<SocialMedia>(model);
            var isCreated = await _socialMediaWriteRepository.AddAsync(entity);
            return Ok(isCreated);
        }

        [HttpPut]
        [Route("update-social-media")]
        public async Task<IActionResult> Update([FromBody] SocialMediaUpdateDTO model)
        {
            var entity = _mapper.Map<SocialMedia>(model);
            var isUpdated = await _socialMediaWriteRepository.UpdateAsync(entity);
            return Ok(isUpdated);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await _socialMediaWriteRepository.RemoveAsync(id);
            return Ok(new
            {
                result,
                id
            });
        }
    }
}
