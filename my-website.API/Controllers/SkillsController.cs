using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_website.Application.DTOS.SkillsDTOS;
using my_website.Application.Repositories.SkillsRepository;
using my_website.Domain.Entities;

namespace my_website.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillReadRepository _skillsReadRepository;
        private readonly ISkillWriteRepository _skillsWriteRepository;
        private readonly IMapper _mapper;

        public SkillsController(ISkillReadRepository skillsReadRepository, ISkillWriteRepository skillsWriteRepository, IMapper mapper)
        {
            _skillsReadRepository = skillsReadRepository;
            _skillsWriteRepository = skillsWriteRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> Get()
        {
            var data = _skillsReadRepository.GetAll();
            return Ok(data);
        }

        [HttpPost]
        [Route("create-skill")]
        public async Task<IActionResult> Create([FromBody] SkillsCreateDTO model)
        {
            var entity = _mapper.Map<Skills>(model);
            var isCreated = await _skillsWriteRepository.AddAsync(entity);
            return Ok(isCreated);
        }

        [HttpPut]
        [Route("update-skill")]
        public async Task<IActionResult> Update([FromBody] SkillsUpdateDTO model)
        {
            var entity = _mapper.Map<Skills>(model);
            var isUpdated = await _skillsWriteRepository.UpdateAsync(entity);
            return Ok(isUpdated);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await _skillsWriteRepository.RemoveAsync(id);
            return Ok(new
            {
                result,
                id
            });
        }

    }
}
