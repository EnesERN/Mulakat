using Mulakat.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mulakat.Data.Helpers
{
    public static class MulakatHelper
    {
        public static string HashPassword(string password)
        {
            byte[] data = Encoding.ASCII.GetBytes(password);
            string hashPassword = "";
            byte[] result;
            SHA1 shaM = new SHA1Managed();
            result = shaM.ComputeHash(data);
            for (int i = 0; i < result.Length; i++)
            {
                hashPassword += result[i].ToString();
            }
            return hashPassword;
        }

        public static async Task<IEnumerable<Movie>> RetrieveMovies()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://www.omdbapi.com/?apikey=f5011fd8&s=batman";
                using (var Response = await client.GetAsync(url))
                {
                    var contents = await Response.Content.ReadAsStringAsync();
                    if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        List<Movie> deserialized = JsonConvert.DeserializeObject<RetrieveMoviesResult>(contents).Search;
                        for (int i = 0; i < deserialized.Count(); i++)
                        {
                            deserialized[i].ID = Guid.NewGuid();
                        }
                        return deserialized;
                    }
                    else
                    {
                        return new List<Movie>();

                    }
                }
            }
        }
    }

    public class RetrieveMoviesResult
    {
        public List<Movie> Search { get; set; }
        public string totalResults { get; set; }
        public string Response { get; set; }
    }
}
