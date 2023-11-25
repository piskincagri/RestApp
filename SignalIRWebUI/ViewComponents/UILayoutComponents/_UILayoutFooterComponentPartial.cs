using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignaIRWebUI.Dtos.ContactDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SignaIRWebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutFooterComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _UILayoutFooterComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44374/api/Contact");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
            return View(values);


        }

    }
}
