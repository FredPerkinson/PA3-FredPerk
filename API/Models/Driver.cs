using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Driver
    {
        public int id { get; set; }

        public string? firstName { get; set; }

        public double rating {get; set;}

        public DateTime dateHired  { get; set; }

        public Boolean deleted {get; set;}

        public Driver()
        {
            dateHired = DateTime.Now;
        }
    }
}