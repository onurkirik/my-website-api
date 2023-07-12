using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_website.Application.DTOS.CertificateDTOS;
using my_website.Application.Repositories.CertificateRepository;
using my_website.Domain.Entities;
using System.Security.Policy;

namespace my_website.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateContoller : ControllerBase
    {
        private readonly ICertificateReadRepository _certificateReadRepository;
        private readonly ICertificateWriteRepository _certificateWriteRepository;
        private readonly IMapper _mapper;

        public CertificateContoller(ICertificateReadRepository certificateReadRepository, ICertificateWriteRepository certificateWriteRepository, IMapper mapper)
        {
            _certificateReadRepository = certificateReadRepository;
            _certificateWriteRepository = certificateWriteRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> Get()
        {
            var data = _certificateReadRepository.GetAll();
            return Ok(data);
        }

        [HttpPost]
        [Route("create-certificate")]
        public async Task<IActionResult> Create([FromBody] CertificateCreateDTO model)
        {
            var entity = _mapper.Map<Certificate>(model);
            var isCreated = await _certificateWriteRepository.AddAsync(entity);
            return Ok(isCreated);
        }

        [HttpPut]
        [Route("update-certificate")]
        public async Task<IActionResult> Update([FromBody] CertificateUpdateDTO model)
        {
            var entity = _mapper.Map<Certificate>(model);
            var isUpdated = await _certificateWriteRepository.UpdateAsync(entity);
            return Ok(isUpdated);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await _certificateWriteRepository.RemoveAsync(id);
            return Ok(new
            {
                result,
                id
            });
        }

    }
}
