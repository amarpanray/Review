using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lolo.Models.BusinessObjects
{
    public class Review
    {
        public string id { get; set; }
        public string alias { get; set; }   
        public string name { get; set; }
        public string image_url { get; set; }
        public bool is_claimed { get; set; }
        public bool is_closed { get; set; }
        public string url { get; set; }
        public string price { get; set; }         
        public double rating { get; set; }
        public int review_count { get; set; }
        public string phone { get; set; }
        public string [] photos { get; set; }

        public List<Open> hours { get; set; }
    }
}