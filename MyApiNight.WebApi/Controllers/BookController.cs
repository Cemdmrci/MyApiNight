using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApiNight.BusinessLayer.Abstract;
using MyApiNight.EntityLayer.Concrete;

namespace MyApiNight.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult BookList()
        {
            var values = _bookService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            _bookService.TInsert(book);
            return Ok("Ekleme Başarılı!");
        }

        [HttpDelete]
        public IActionResult DeleteBook(int id)
        {
            _bookService.TDelete(id);
            return Ok("Silme Başarılı!");
        }

        [HttpPut]
        public IActionResult UpdateBook(Book book)
        {
            _bookService.TUpdate(book);
            return Ok("Güncelleme Yapıldı!");
        }
        [HttpGet("GetBook")]
        public IActionResult GetBook(int id)
        {
            var value = _bookService.TGetById(id);
            return Ok(value);
        }
        [HttpGet("BookCount")]
        public IActionResult WriterCount()
        {
            return Ok(_bookService.TGetBookCount());
        }
		[HttpGet("GetLast4Books")]
		public IActionResult GetLast4Books()
		{
			var values = _bookService.TGetLast4Books();
			return Ok(values);
		}
        [HttpGet("GetPopularBooks")]
        public IActionResult GetPopularBooks()
        {
            var values = _bookService.TGetPopularBooks();
            return Ok(values);
        }
		[HttpGet("GetRandomBook")]
		public IActionResult GetRandomBook()
		{
			var value = _bookService.TGetRandomBook();
			return Ok(value);
		}
		[HttpGet("GetAllCategories")]
		public IActionResult GetAllCategories()
		{
			var values = _bookService.TGetAllCategories();
			return Ok(values);
		}

		[HttpGet("GetPersonalDevelopment")]
		public IActionResult GetPersonalDevelopment()
		{
			var values = _bookService.TGetPersonalDevelopment();
			return Ok(values);
		}

		[HttpGet("GetNovel")]
		public IActionResult GetNovel()
		{
			var values = _bookService.TGetNovel();
			return Ok(values);
		}

		[HttpGet("GetHistory")]
		public IActionResult GetHistory()
		{
			var values = _bookService.TGetHistory();
			return Ok(values);
		}

		[HttpGet("GetForeignBook")]
		public IActionResult GetForeignBook()
		{
			var values = _bookService.TGetForeignBook();
			return Ok(values);
		}

		[HttpGet("GetScience")]
		public IActionResult GetScience()
		{
			var values = _bookService.TGetScience();
			return Ok(values);
		}

		[HttpGet("GetSoftware")]
		public IActionResult GetSoftware()
		{
			var values = _bookService.TGetSoftware();
			return Ok(values);
		}
	}
}

