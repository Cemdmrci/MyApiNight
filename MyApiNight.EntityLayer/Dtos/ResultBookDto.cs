using MyApiNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.EntityLayer.Dtos
{
	public class ResultBookDto
	{
		public int BookID { get; set; }
		public string BookName { get; set; }
		public decimal Price { get; set; }
		public int PageCount { get; set; }
		public string ImageUrl { get; set; }
		public int? WriterId { get; set; }
		public Writer? Writer { get; set; }
		public int CategoryId { get; set; }
		public Category? Category { get; set; }
	}
}
