using MyApiNight.EntityLayer.Concrete;
using MyApiNight.EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.DataAccessLayer.Abstract
{
    public interface IWriterDal:IGenericDal<Writer>
    {
        int GetWrriterCount();
        List<GetWriterListDto> GetWriterList();
    }
}
