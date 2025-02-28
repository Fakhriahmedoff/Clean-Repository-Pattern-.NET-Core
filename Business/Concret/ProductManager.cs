﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concret
{
    public class ProductManager : IProductService 
        
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p=>p.CategoryID==categoryId);
        }
    }
}
