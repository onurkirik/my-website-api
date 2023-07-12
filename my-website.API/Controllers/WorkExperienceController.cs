using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_website.Application.DTOS.WorkExperienceDTOS;
using my_website.Application.Repositories.WorkExperienceRepository;
using my_website.Domain.Entities;

namespace my_website.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkExperienceController : ControllerBase
    {
        private readonly IWorkExperienceReadRepository _workExperienceReadRepository;
        private readonly IWorkExperienceWriteRepository _workExperienceWriteRepository;
        private readonly IMapper _mapper;

        public WorkExperienceController(IWorkExperienceReadRepository workExperienceReadRepository, IWorkExperienceWriteRepository workExperienceWriteRepository, IMapper mapper)
        {
            _workExperienceReadRepository = workExperienceReadRepository;
            _workExperienceWriteRepository = workExperienceWriteRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> Get()
        {
            var data = _workExperienceReadRepository.GetAll();
            return Ok(data);
        }

        [HttpPost]
        [Route("create-work-experience")]
        public async Task<IActionResult> Create([FromBody] WorkExperienceCreateDTO model)
        {
            var entity = _mapper.Map<WorkExperience>(model);
            var isCreated = await _workExperienceWriteRepository.AddAsync(entity);
            return Ok(isCreated);
        }

        [HttpPut]
        [Route("update-work-experience")]
        public async Task<IActionResult> Update([FromBody] WorkExperienceUpdateDTO model)
        {
            var entity = _mapper.Map<WorkExperience>(model);
            var isUpdated = await _workExperienceWriteRepository.UpdateAsync(entity);
            return Ok(isUpdated);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await _workExperienceWriteRepository.RemoveAsync(id);
            return Ok(new
            {
                result,
                id
            });
        }
    }
}
