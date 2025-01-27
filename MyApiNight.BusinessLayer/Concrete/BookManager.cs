using MyApiNight.BusinessLayer.Abstract;
using MyApiNight.DataAccessLayer.Abstract;
using MyApiNight.EntityLayer.Concrete;
using MyApiNight.EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.BusinessLayer.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void TDelete(int id)
        {
            _bookDal.Delete(id);
        }

        public List<Book> TGetAll()
        {
            return _bookDal.GetAll();
        }

		public List<GetPopularBooksDto> TGetAllCategories()
		{
			return _bookDal.GetAllCategories();
		}

		public int TGetBookCount()
        {
            return _bookDal.GetBookCount();
        }

        public Book TGetById(int id)
        {
            return _bookDal.GetById(id);
        }

		public List<GetPopularBooksDto> TGetForeignBook()
		{
			return _bookDal.GetForeignBook();
		}

		public List<GetPopularBooksDto> TGetHistory()
		{
			return _bookDal.GetHistory();
		}

		public List<GetLast4BooksDto> TGetLast4Books()
		{
			return _bookDal.GetLast4Books();
		}

		public List<GetPopularBooksDto> TGetNovel()
		{
			return _bookDal.GetNovel();
		}

		public List<GetPopularBooksDto> TGetPersonalDevelopment()
		{
			return _bookDal.GetPersonalDevelopment();
		}

		public List<GetPopularBooksDto> TGetPopularBooks()
		{
			return _bookDal.GetPopularBooks();
		}

		public GetRandomBookDto TGetRandomBook()
		{
			return _bookDal.GetRandomBook();
		}

		public List<GetPopularBooksDto> TGetScience()
		{
			return _bookDal.GetScience();
		}

		public List<GetPopularBooksDto> TGetSoftware()
		{
			return _bookDal.GetSoftware();
		}

		public void TInsert(Book entity)
        {
            _bookDal.Insert(entity);
        }

        public void TUpdate(Book entity)
        {
            _bookDal.Update(entity);
        }
    }
}
