using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concret
{
    class CategoryManager : ICategoryService
    {
        private ICategoryService _categoryService;

        public CategoryManager(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public List<Category> GetAll()
        {
            return _categoryService.GetAll();
        }

      
    }
}
