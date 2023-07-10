using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_website.Application.Repositories.ProjectRepository;

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
        public async Task<IActionResult> Create()
        {
            
        }

    }
}
