﻿namespace MyApiNight.EntityLayer.Dtos
{
	public class GetPopularBooksDto
	{
		public int BookId { get; set; }
		public string BookName { get; set; }
		public string  WriterName { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
		public string CategoryName { get; set; }
	}
}
