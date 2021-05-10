using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }

        public virtual IEnumerable<Doctor> Doctors { get; set; }
        public virtual IEnumerable<Point> Points { get; set; }
    }
}
