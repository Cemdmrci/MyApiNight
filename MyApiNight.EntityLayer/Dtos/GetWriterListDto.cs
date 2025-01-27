namespace MyApiNight.EntityLayer.Dtos
{
	public class GetWriterListDto
	{
		public int WriterId { get; set; }
		public string WriterNameSurname { get; set; }
		public string ImageUrl { get; set; }
		public string About { get; set; }
		public string BookCount { get; set; }
	}
}
