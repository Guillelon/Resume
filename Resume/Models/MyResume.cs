using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class MyResume
    {
        public Information Info { get; set; }
        public List<Education> Education { get; set; }
        public List<Job> Experience { get; set; }
        public string Objective { get; set; }
        public List<string> Abilities { get; set; }
        public List<string> Knowledge { get; set; }
    }
}