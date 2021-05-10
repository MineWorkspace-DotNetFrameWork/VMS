using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Journal
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int PointId { get; set; }
        public virtual Point Point { get; set; }
        public int VaccineId { get; set; }
        public virtual Vaccine Vaccine { get; set; }

    }
}
