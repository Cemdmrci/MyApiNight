using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.EntityLayer.Dtos
{
	public class CreateWriterDto
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string About { get; set; }
		public string ImageUrl { get; set; }
	}
}
