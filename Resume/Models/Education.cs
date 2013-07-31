using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class Education
    {
        public string Where { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Title { get; set; }
        public DateTime Since { get; set; }
        public DateTime Until { get; set; }
    }
}