﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_website.Application.DTOS.CategoriesDTOS;
using my_website.Application.Repositories.CategoryRepository;
using my_website.Domain.Entities;
using System.Formats.Asn1;

namespace my_website.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository, IMapper mapper)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> Get()
        {
            return Ok(_categoryReadRepository.GetAll());
        }

        [HttpPost]
        [Route("create-category")]
        public async Task<IActionResult> Create([FromBody] CategoryCreateDto model)
        {
            var entity = _mapper.Map<Category>(model);

            return Ok(await _categoryWriteRepository.AddAsync(entity));
        }

        [HttpPut]
        [Route("update-category")]
        public async Task<IActionResult> Update([FromBody] CategoryUpdateDto model)
        {
            var entity = _mapper.Map<Category>(model);

            var isUpdated = await _categoryWriteRepository.UpdateAsync(entity);
            return Ok(isUpdated);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await _categoryWriteRepository.RemoveAsync(id);

            return Ok(new
            {
                result,
                id
            });
        }

    }
}
