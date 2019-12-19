using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> NotLike { get; set; }

        public Doctor(int id, string name, List<int> notLike)
        {
            Id = id;
            Name = name;
            NotLike = notLike;
        }
    }
}
