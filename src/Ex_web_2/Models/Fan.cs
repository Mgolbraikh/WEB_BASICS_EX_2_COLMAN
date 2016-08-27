using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_web_2.Models
{
    public class Fan
    {
        public int ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String Gender { get; set; }

        public DateTime BirthDate { get; set; }
        public int YearsInClub { get; set; }
    }
}
