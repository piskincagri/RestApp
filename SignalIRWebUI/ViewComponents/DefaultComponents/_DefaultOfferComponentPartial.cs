using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignaIRWebUI.Dtos.DiscountDtos;
using SignaIRWebUI.Dtos.SliderDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SignaIRWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultOfferComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultOfferComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44374/api/Discount/GetListByStatusTrue");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultDiscountDto>>(jsonData);
            return View(values);


        }

    }
}
