using MyApiNight.EntityLayer.Concrete;
using MyApiNight.EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.BusinessLayer.Abstract
{
    public interface IWriterService:IGenericService<Writer>
    {
        public int TGetWriterCount();
         public List<GetWriterListDto> TGetWriterList();
    }
}
