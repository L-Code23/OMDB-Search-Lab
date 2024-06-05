using Microsoft.AspNetCore.DataProtection;
using Newtonsoft.Json;
using System.Net;

namespace Searching_OMDB.Models
{
    public class OMDbDAL
    {
        public static OMDb GetMovie(string title)//Adjust
        {
            //adjust
            //setup
            string url = $"http://www.omdbapi.com/?t=t&apikey={Secret.apiKey}";
            //show how to hide API key

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //adjust
            //Convert to c#
            //Install Newtonsoft.json
            OMDb result = JsonConvert.DeserializeObject<OMDb>(JSON);

            return result;
        }
        public static OMDb GetMovies(string title1, string title2, string title3)//Adjust
        {
            //adjust
            //setup
            string url = $"http://www.omdbapi.com/?t=&apikey={Secret.apiKey}";
            //show how to hide API key

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //adjust
            //Convert to c#
            //Install Newtonsoft.json
            OMDb result = JsonConvert.DeserializeObject<OMDb>(JSON);

            return result;
        }
    }
}
