using System.Net.Http;

namespace lolo.Models.DataServices.APICalls
{
    public class YELP: API
    {  
        private readonly string _url = null;  
        private readonly string APIKeys = null;  
                
        public string YELPAPI { get; set; }

        public YELP()
        {
            _url = System.Configuration.ConfigurationManager.AppSettings["YelpAPIEndPoint"];
            APIKeys = System.Configuration.ConfigurationManager.AppSettings["YelpAPIToken"];

            YELPAPI = base.ReadAPI(_url, APIKeys);
        }
        
    }
}