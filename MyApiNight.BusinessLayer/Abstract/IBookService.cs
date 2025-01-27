using MyApiNight.EntityLayer.Concrete;
using MyApiNight.EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.BusinessLayer.Abstract
{
	public interface IBookService : IGenericService<Book>
	{
		public int TGetBookCount();
		public List<GetLast4BooksDto> TGetLast4Books();
		public List<GetPopularBooksDto> TGetPopularBooks();
		public GetRandomBookDto TGetRandomBook();
		public List<GetPopularBooksDto> TGetAllCategories();
		public List<GetPopularBooksDto> TGetPersonalDevelopment();
		public List<GetPopularBooksDto> TGetNovel();
		public List<GetPopularBooksDto> TGetHistory();
		public List<GetPopularBooksDto> TGetForeignBook();
		public List<GetPopularBooksDto> TGetScience();
		public List<GetPopularBooksDto> TGetSoftware();
	}
}
