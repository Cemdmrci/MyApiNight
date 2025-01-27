using MyApiNight.DataAccessLayer.Abstract;
using MyApiNight.DataAccessLayer.Context;
using MyApiNight.DataAccessLayer.Repositories;
using MyApiNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.DataAccessLayer.EntityFramework //imzasını attığımız şeylerin imzasını burada doldururuz.Genericrepository ilgili entityle(product) ile haberleştiriliyor.
{
    public class EfProductDal : GenericRepository<Product>, IProductDal //,Iproductdal dememizin sebebi producta özel bir metot tanımlayacak olursak ondan miras alsın diye bunu yapıyoruz.
    {
        public EfProductDal(ApiContext context) : base(context)
        {
        }

        public int GetProductCount()
        {
            var context = new ApiContext();
            int value = context.Products.Count();
            return value;
        }
    }
}
