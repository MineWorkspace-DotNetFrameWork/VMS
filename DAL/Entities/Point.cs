using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Point
    {
        public int Id { get; set; }

        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual IEnumerable<Journal> Journals { get; set; }

    }
}
