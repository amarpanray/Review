using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lolo.Models.BusinessObjects
{
    public class Hour
    {
        public string hour_type { get; set; }
        public List<Open> open { get; set; }
    }
}