using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignaIRWebUI.Dtos.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SignaIRWebUI.Controllers
{
    public class MenuController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MenuController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44374/api/Product");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
            return View(values);


        }
    }
}
