using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.EntityLayer.Concrete
{
    public class Writer
    {
        public int WriterID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string About { get; set; }
        public string ImageUrl { get; set; }
        public List<Book>? Books { get; set; }
    }
}
