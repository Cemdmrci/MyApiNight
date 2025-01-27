namespace MyApiNight.EntityLayer.Dtos
{
	public class GetRandomBookDto
	{
		public int BookId { get; set; }
		public string BookName { get; set; }
		public string ImageUrl { get; set; }
		public string WriterName { get; set; }
		public string CategoryName { get; set; }
		public int PageCount { get; set; }
	}
}
