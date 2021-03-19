using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulakat.Data.Models
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Poster { get; set; }
    }
}
