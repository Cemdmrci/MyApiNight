using Microsoft.AspNetCore.Mvc;
using MyApiNight.EntityLayer.Dtos;
using Newtonsoft.Json;
using System.Text;

namespace MyApiNight.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class BookController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public BookController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> BookList()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7123/api/Book");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultBookDto>>(jsonData);
				return View(values);
			}
			return View();
		}

		[HttpGet]
		public IActionResult CreateBook()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateBook(CreateBookDto createBookDto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createBookDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var reponseMessage = await client.PostAsync("https://localhost:7123/api/Book", stringContent);
			if (reponseMessage.IsSuccessStatusCode)
			{
				return Redirect("BookList");
			}
			return View();
		}

		public async Task<IActionResult> DeleteBook(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync("https://localhost:7123/api/Book?id=" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				return Redirect("BookList");
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> UpdateBook(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7123/api/Book/GetBook?id=" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateBookDto>(jsonData);
				return View(values);
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> UpdateBook(UpdateBookDto updateBookDto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateBookDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("https://localhost:7123/api/Book", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return Redirect("BookList");
			}
			return View();
		}
	}
}
