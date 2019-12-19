using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1.Models
{
    public class Instance
    {
        public List<Doctor> Doctors { get; set; }
        public int Days { get; set; }

        public Instance()
        {
            Doctors = new List<Doctor>();
        }
    }
}
