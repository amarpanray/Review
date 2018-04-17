using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lolo.Models.BusinessObjects
{
    public class Open
    {
        public bool is_overnight { get; set; }
        public string end { get; set; }
        public bool day { get; set; }
        public string start { get; set; }

        public bool is_open_now { get; set; }
    }
}