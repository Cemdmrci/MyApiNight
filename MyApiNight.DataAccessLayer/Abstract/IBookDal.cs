using MyApiNight.EntityLayer.Concrete;
using MyApiNight.EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.DataAccessLayer.Abstract
{
    public interface IBookDal : IGenericDal<Book>
    {
        int GetBookCount();
		List<GetLast4BooksDto> GetLast4Books();
		List<GetPopularBooksDto> GetPopularBooks();
		GetRandomBookDto GetRandomBook();
		List<GetPopularBooksDto> GetAllCategories();
		List<GetPopularBooksDto> GetPersonalDevelopment();
		List<GetPopularBooksDto> GetNovel();
		List<GetPopularBooksDto> GetHistory();
		List<GetPopularBooksDto> GetForeignBook();
		List<GetPopularBooksDto> GetScience();
		List<GetPopularBooksDto> GetSoftware();

	}
}
