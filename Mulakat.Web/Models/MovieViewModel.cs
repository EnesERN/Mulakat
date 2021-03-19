using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mulakat.Web.Models
{
    public class MovieViewModel
    {
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Lütfen film adı giriniz!")]
        [Display(Name = "Film Adı")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen film yılı giriniz!")]
        [Display(Name = "Film Yılı")]
        public string Year { get; set; }
        public string Poster { get; set; }
    }
}
