using System;
using System.Collections.Generic;
using System.Text;

namespace DevTechTestDAL.Models
{
    public class vmStudent
    {
        public int studentid { get; set; } 
        public string fname { get; set; }
        public string familyname { get; set; }
        public DateTime dob { get; set; }
        public string email { get; set; }
    }
}
