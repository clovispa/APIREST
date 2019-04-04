using APIFINAL3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> BuscarPais(string codigoPais)
        {
            CiudadWM pais = new CiudadWM();
            string urlApi = ConfigurationManager.AppSettings["UrlApi"];

            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(urlApi);

                cliente.DefaultRequestHeaders.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                HttpResponseMessage Response = await cliente.GetAsync($"data/2.5/forecast/hourly?zip={codigoPais}&appid=a61121d3e8c2375140779bab6ac40378");

                if (Response.IsSuccessStatusCode)
                {
                    var paisResponse = Response.Content.ReadAsStringAsync().Result;

                    pais = JsonConvert.DeserializeObject<CiudadWM>(paisResponse);

                }

                return View("Index", pais);
            }
        }
    }
}