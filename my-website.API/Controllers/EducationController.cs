using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_website.Application.DTOS.EducationDTOS;
using my_website.Application.Repositories.EducationRepository;
using my_website.Domain.Entities;
using System.Security.Policy;

namespace my_website.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly IEducationReadRepository _educationReadRepository;
        private readonly IEducationWriteRepository _educationWriteRepository;
        private readonly IMapper _mapper;

        public EducationController(IEducationReadRepository educationReadRepository, IEducationWriteRepository educationWriteRepository, IMapper mapper)
        {
            _educationReadRepository = educationReadRepository;
            _educationWriteRepository = educationWriteRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> Get()
        {
            var data = _educationReadRepository.GetAll();
            return Ok(data);
        }

        [HttpPost]
        [Route("create-education")]
        public async Task<IActionResult> Create([FromBody] EducationCreateDTO model)
        {
            var entity = _mapper.Map<Education>(model);
            var isCreated = await _educationWriteRepository.AddAsync(entity);
            return Ok(isCreated);
        }

        [HttpPut]
        [Route("update-education")]
        public async Task<IActionResult> Update([FromBody] EducationUpdateDTO model)
        {
            var entity = _mapper.Map<Education>(model);
            var isUpdated = await _educationWriteRepository.UpdateAsync(entity);
            return Ok(isUpdated);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await _educationWriteRepository.RemoveAsync(id);
            return Ok(new
            {
                result,
                id
            });
        }
    }
}
