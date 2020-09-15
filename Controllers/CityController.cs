using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace my_first_api.Controllers
{
    [ApiController]
    [Route("[controller]")]

     public class CityController : ControllerBase
     {

         /* Sample data of cities */
         private static string[] Cities = new[]
        {
            "Manila", "Pasay", "Quezon", "Malabon", "Pasig", "Rizal"
        };

        [HttpGet("/api/cities/{name}")]
        public Array filterCity(string name)
        {
            List<string> response = new List<string>();

            for (int i = 0; i < Cities.Length; i++)
            {
                if(Cities[i] == name)
                {
                    response.Add(Cities[i]);
                }
            }
            
            return response.ToArray();
        }

        [HttpGet("/api/cities")]    
        public Array Get()
        {
            return Cities;
        }

        [HttpPost("/api/cities")]
        public Array Create(string city)
        {
            List<string> response = new List<string>();

            for (int i = 0; i < Cities.Length; i++)
            {
                response.Add(Cities[i]);
            }

            response.Add(city);

            return response.ToArray();
        }

     }
}