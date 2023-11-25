using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignaIRWebUI.Dtos.AboutDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SignaIRWebUI.ViewComponents.DefaultComponents
{
    public class _DefatultAboutComponentPartial: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefatultAboutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44374/api/About");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
            return View(values);


        }


    }
}
