﻿using MyApiNight.BusinessLayer.Abstract;
using MyApiNight.DataAccessLayer.Abstract;
using MyApiNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        //CategoryManager cm=new CategoryManager(new EfCategoryDal());
        //Autofac
        public void TDelete(int id)
        {
           _categoryDal.Delete(id);
        }
        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }
        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public int TGetCategoryCount()
        {
           return _categoryDal.GetCategoryCount();
        }

        public void TInsert(Category entity)
        {
           _categoryDal.Insert(entity);
        }
        public void TUpdate(Category entity)
        {
           _categoryDal.Update(entity);
        }
    }
}
