using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulakat.Data.Models
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Guid CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public Guid ModifiedBy { get; set; }


        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
