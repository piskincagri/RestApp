using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignaIRWebUI.Dtos.TestimonialDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SignaIRWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultTestimonialComponentPartial:ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultTestimonialComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44374/api/Testimonial");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
            return View(values);


        }

    }
}
