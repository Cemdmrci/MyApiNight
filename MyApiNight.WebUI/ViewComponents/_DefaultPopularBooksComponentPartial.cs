using Microsoft.AspNetCore.Mvc;
using MyApiNight.EntityLayer.Dtos;
using Newtonsoft.Json;

namespace MyApiNight.WebUI.ViewComponents
{
	public class _DefaultPopularBooksComponentPartial :ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _DefaultPopularBooksComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			//var client = _httpClientFactory.CreateClient();
			//var responseMessage = await client.GetAsync("");
			//if (responseMessage.IsSuccessStatusCode)
			//{
			//	var jsonData = await responseMessage.Content.ReadAsStringAsync();
			//	var values = JsonConvert.DeserializeObject<List<GetPopularBooksDto>>(jsonData);
			//	return View(values);
			//}
			return View();
		}
	}
}
