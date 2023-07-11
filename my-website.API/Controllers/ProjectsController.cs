using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_website.Application.DTOS.ProjectDTOS;
using my_website.Application.Repositories.ProjectRepository;
using my_website.Domain.Entities;

namespace my_website.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectReadRepository _projectReadRepository;
        private readonly IProjectWriteRepository _projectWriteRepository;
        private readonly IMapper _mapper;
        public ProjectsController(IProjectReadRepository projectReadRepository, IProjectWriteRepository projectWriteRepository, IMapper mapper)
        {
            _projectReadRepository = projectReadRepository;
            _projectWriteRepository = projectWriteRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> Get()
        {
            var data = _projectReadRepository.GetAll();
            return Ok(data);
        }


        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var data = await _projectReadRepository.GetByIdAsync(id, false);
            return Ok(data);
        }

        [HttpPost]
        [Route("create-project")]
        public async Task<IActionResult> Create([FromBody] ProjectCreateDTO model)
        {
            var entity = _mapper.Map<Project>(model);
            var isCreated = await _projectWriteRepository.AddAsync(entity);
            return Ok(isCreated);
        }

        [HttpPut]
        [Route("update-project")]
        public async Task<IActionResult> Update([FromBody] ProjectUpdateDTO model)
        {
            var entity = _mapper.Map<Project>(model);
            var isUpdated = await _projectWriteRepository.UpdateAsync(entity);

            return Ok(isUpdated);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromBody] Guid id)
        {
            var result = await _projectWriteRepository.RemoveAsync(id);
            return Ok(new
            {
                result,
                id
            });
        }

    }
}
