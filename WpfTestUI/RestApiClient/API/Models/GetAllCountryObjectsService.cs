using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WpfTestUI.RestApiClient.Models;

namespace WpfTestUI.RestApiClient.API.Models
{
    public class GetAllCountryObjectsService
    {
    //    public static List<Person> Persons { get; set; }
    //    public static List<Country> Countries { get; set; }

        public static async void GetAllCountries()
        {

            //using (HttpClient client = new HttpClient())
            //{
            //    string requestUri = "https://localhost:44344/api/country";

            //    HttpResponseMessage apiResponse = await client.GetAsync(requestUri);
            //    if (apiResponse.IsSuccessStatusCode)
            //    {
            //        Countries = await apiResponse.Content.ReadAsAsync<List<Country>>();
            //    }
                
            //}
        }
        public static async void GetAllPersons()
        {
            //using (HttpClient client = new HttpClient())
            //{
            //    string requestUri = "https://localhost:44344/api/person";

            //    HttpResponseMessage apiResponse = await client.GetAsync(requestUri);
            //    if (apiResponse.IsSuccessStatusCode)
            //    {
            //        Persons = await apiResponse.Content.ReadAsAsync<List<Person>>();
            //    }
            //}
        }
    }
}