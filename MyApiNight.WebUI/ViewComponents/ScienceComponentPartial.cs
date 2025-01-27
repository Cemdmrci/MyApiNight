using Microsoft.AspNetCore.Mvc;
using MyApiNight.EntityLayer.Dtos;
using Newtonsoft.Json;

namespace MyApiNight.WebUI.ViewComponents
{
	public class ScienceComponentPartial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public ScienceComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7123/api/Book/GetScience");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<GetPopularBooksDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
