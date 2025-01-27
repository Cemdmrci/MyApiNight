using MyApiNight.DataAccessLayer.Abstract;
using MyApiNight.DataAccessLayer.Context;
using MyApiNight.DataAccessLayer.Repositories;
using MyApiNight.EntityLayer.Concrete;
using MyApiNight.EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.DataAccessLayer.EntityFramework
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
        private readonly ApiContext _context;
        public EfWriterDal(ApiContext context) : base(context)
        {
            _context = context;
        }

        public List<GetWriterListDto> GetWriterList()
        {
            return _context.Writers
                .OrderByDescending(a => a.WriterID)
                .Select(a => new GetWriterListDto
                {
                    WriterId = a.WriterID,
                    WriterNameSurname = a.Name + " " + a.Surname,
                    ImageUrl = a.ImageUrl,
                    About = a.About,
                    BookCount = _context.Books.Count(book => book.WriterId == a.WriterID).ToString()
                })
                .ToList();
        }

        public int GetWrriterCount()
        {
            var context = new ApiContext();
            int value = context.Writers.Count();
            return value;
        }
    }
}
