﻿using FreeCourse.Services.Catalag.Models;
using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Services
{
    interface ICategoryService
    {
        Task<Response<CategoryDto>> CreateAsync(CategoryDto categoryDto);
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> GetById(string id);
    }
}