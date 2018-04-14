using DemoApp.APIHelper;
using DemoApp.Business;
using DemoApp.Business.Contracts;
using DemoApp.Entities.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        private IProductManager service;
        BaseAPI _productAPI = new BaseAPI();
        public HomeController(IProductManager service)
        {
            this.service = service;
        }

        //public ActionResult Index()
        //{
        //    var data = service.GetAll().Count();
        //    ViewBag.productCount = data;
        //    return View();
        //}

        public async Task<ActionResult> Index()
        {
            //https://www.c-sharpcorner.com/article/building-an-asp-net-core-application-with-web-api-and-code-first-development/

            List<Product> dto = new List<Product>();

            HttpClient client = _productAPI.InitializeClient();

            HttpResponseMessage res = await client.GetAsync("Products");

            //Checking the response is successful or not which is sent using HttpClient    
            if (res.IsSuccessStatusCode)
            {
                //Storing the response details recieved from web api     
                var result = res.Content.ReadAsStringAsync().Result;

                //Deserializing the response recieved from web api and storing into the Employee list    
                dto = JsonConvert.DeserializeObject<List<Product>>(result);

            }

            //returning the employee list to view    
            ViewBag.productCount = dto.Count();
            return View(dto);
        }
    }
}