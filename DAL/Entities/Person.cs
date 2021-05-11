using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DAL.Entities
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        [Required]
        [StringLength(100)]
        public string Phone { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }
        [DataType(DataType.Date)]
        public DateTime? First { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Second { get; set; }
        
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual IEnumerable<Journal> Journals { get; set; }
    }
}
