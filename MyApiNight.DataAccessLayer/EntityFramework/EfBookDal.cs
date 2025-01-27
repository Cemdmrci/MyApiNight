using Microsoft.EntityFrameworkCore;
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
	public class EfBookDal : GenericRepository<Book>, IBookDal
	{
		private readonly ApiContext _context;
		public EfBookDal(ApiContext context) : base(context)
		{
			_context = context;
		}

		public List<GetPopularBooksDto> GetAllCategories()
		{
			return _context.Books
	.Include(b => b.Writer)
	.Include(b => b.Category)
	.OrderByDescending(b => b.BookID)
	.Select(b => new GetPopularBooksDto
	{
		BookId = b.BookID,
		BookName = b.BookName,
		ImageUrl = b.ImageUrl,
		WriterName = b.Writer != null ? b.Writer.Name + " " + b.Writer.Surname : null,
		CategoryName = b.Category != null ? b.Category.CategoryName : null
	})
	.ToList();
		}


		public int GetBookCount()
		{
			var context = new ApiContext();
			int value = context.Books.Count();
			return value;
		}

		public List<GetPopularBooksDto> GetForeignBook()
		{
			return _context.Books
.Include(b => b.Writer)
.Include(b => b.Category)
.Where(b => b.Category.CategoryName == "Yabancı Kitap")
.OrderByDescending(b => b.BookID)
.Select(b => new GetPopularBooksDto
{
	BookId = b.BookID,
	BookName = b.BookName,
	ImageUrl = b.ImageUrl,
	WriterName = b.Writer != null ? b.Writer.Name + " " + b.Writer.Surname : null,
	CategoryName = b.Category != null ? b.Category.CategoryName : null
})
.ToList();
		}

		public List<GetPopularBooksDto> GetHistory()
		{
			return _context.Books
.Include(b => b.Writer)
.Include(b => b.Category)
.Where(b => b.Category.CategoryName == "Tarih")
.OrderByDescending(b => b.BookID)
.Select(b => new GetPopularBooksDto
{
	BookId = b.BookID,
	BookName = b.BookName,
	ImageUrl = b.ImageUrl,
	WriterName = b.Writer != null ? b.Writer.Name + " " + b.Writer.Surname : null,
	CategoryName = b.Category != null ? b.Category.CategoryName : null
})
.ToList();
		}

		public List<GetLast4BooksDto> GetLast4Books()
		{
			return _context.Books
				.Include(b => b.Writer)
				.Include(b => b.Category)
				.OrderByDescending(b => b.BookID)
				.Take(4)
				.Select(b => new GetLast4BooksDto
				{
					BookId = b.BookID,
					BookName = b.BookName,
					Price = b.Price,
					ImageUrl = b.ImageUrl,
					WriterName = b.Writer != null ? b.Writer.Name + " " + b.Writer.Surname : null,
					CategoryName = b.Category != null ? b.Category.CategoryName : null
				})
				.ToList();
		}

		public List<GetPopularBooksDto> GetNovel()
		{
			return _context.Books
.Include(b => b.Writer)
.Include(b => b.Category)
.Where(b => b.Category.CategoryName == "Roman")
.OrderByDescending(b => b.BookID)
.Select(b => new GetPopularBooksDto
{
	BookId = b.BookID,
	BookName = b.BookName,
	ImageUrl = b.ImageUrl,
	WriterName = b.Writer != null ? b.Writer.Name + " " + b.Writer.Surname : null,
	CategoryName = b.Category != null ? b.Category.CategoryName : null
})
.ToList();
		}

		public List<GetPopularBooksDto> GetPersonalDevelopment()
		{
			return _context.Books
.Include(b => b.Writer)
.Include(b => b.Category)
.Where(b => b.Category.CategoryName == "Kişisel Gelişim")
.OrderByDescending(b => b.BookID)
.Select(b => new GetPopularBooksDto
{
	BookId = b.BookID,
	BookName = b.BookName,
	ImageUrl = b.ImageUrl,
	WriterName = b.Writer != null ? b.Writer.Name + " " + b.Writer.Surname : null,
	CategoryName = b.Category != null ? b.Category.CategoryName : null
})
.ToList();
		}

		public List<GetPopularBooksDto> GetPopularBooks()
		{
			return _context.Books
	.Include(b => b.Writer)
	.Include(b => b.Category)
	.OrderByDescending(b => b.BookID)
	.Select(b => new GetPopularBooksDto
	{
		BookId = b.BookID,
		BookName = b.BookName,
		Price = b.Price,
		ImageUrl = b.ImageUrl,
		WriterName = b.Writer != null ? b.Writer.Name + " " + b.Writer.Surname : null,
	})
	.ToList();
		}

		public GetRandomBookDto GetRandomBook()
		{
			var books = _context.Books
					.Include(b => b.Writer)
					.Include(b => b.Category)
					.ToList();

			if (!books.Any())
				return null;

			var random = new Random();
			var randomBook = books[random.Next(books.Count)];

			return new GetRandomBookDto
			{
				BookId = randomBook.BookID,
				BookName = randomBook.BookName,
				PageCount = randomBook.PageCount,
				ImageUrl = randomBook.ImageUrl,
				WriterName = randomBook.Writer != null ? randomBook.Writer.Name + " " + randomBook.Writer.Surname : null,
				CategoryName = randomBook.Category != null ? randomBook.Category.CategoryName : null
			};
		}

		public List<GetPopularBooksDto> GetScience()
		{
			return _context.Books
.Include(b => b.Writer)
.Include(b => b.Category)
.Where(b => b.Category.CategoryName == "Bilim")
.OrderByDescending(b => b.BookID)
.Select(b => new GetPopularBooksDto
{
	BookId = b.BookID,
	BookName = b.BookName,
	ImageUrl = b.ImageUrl,
	WriterName = b.Writer != null ? b.Writer.Name + " " + b.Writer.Surname : null,
	CategoryName = b.Category != null ? b.Category.CategoryName : null
})
.ToList();
		}

		public List<GetPopularBooksDto> GetSoftware()
		{
			return _context.Books
.Include(b => b.Writer)
.Include(b => b.Category)
.Where(b => b.Category.CategoryName == "Yazılım")
.OrderByDescending(b => b.BookID)
.Select(b => new GetPopularBooksDto
{
	BookId = b.BookID,
	BookName = b.BookName,
	ImageUrl = b.ImageUrl,
	WriterName = b.Writer != null ? b.Writer.Name + " " + b.Writer.Surname : null,
	CategoryName = b.Category != null ? b.Category.CategoryName : null
})
.ToList();
		}
	}
}




