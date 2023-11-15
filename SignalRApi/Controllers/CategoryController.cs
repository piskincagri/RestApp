﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignaIR.DtoLayer.CategoryDto;
using SignaIR.EntitiyLayer.Entities;
using SignalR.BussinesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult CategoryList()
        {

            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
            return Ok(value);

        }

        [HttpPost]

        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryService.TAdd(new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                Status = createCategoryDto.Status

            });

            return Ok("Kategori eklendi");


        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {

            var value = _categoryService.TGetByID(id);
            _categoryService.TDelete(value);
            return Ok("Kategori silindi");


        }

        [HttpGet("GetCategory")]

        public IActionResult GetCategory(int id)

        {

            var value = _categoryService.TGetByID(id);
            return Ok(value);
       
        }

        [HttpPut]

        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)

        {
            _categoryService.TUpdate(new Category()
            {
              
              CategoryName=updateCategoryDto.CategoryName,
              CategoryID=updateCategoryDto.CategoryID,
              Status=updateCategoryDto.Status
              
            });
            return Ok("Kategori Güncellendi");
        }


    }
}