using lolo.Models.DataServices.APICalls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace lolo.Models.ViewModels
{
    public class ReviewViewModels
    {
        public string jsonReview { get; set; }

        public void LoadJSONReview()
        {
            YELP _yelp = new YELP();
            
            jsonReview = _yelp.YELPAPI;
        }
    }
}