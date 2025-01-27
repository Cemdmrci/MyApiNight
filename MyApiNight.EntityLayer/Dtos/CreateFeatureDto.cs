using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.EntityLayer.Dtos
{
	public class CreateFeatureDto
	{
		public string BookName { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
	}
}
