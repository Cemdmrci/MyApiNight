using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyApiNight.EntityLayer.Concrete;
using MyApiNight.EntityLayer.Dtos;
using Newtonsoft.Json;

namespace MyApiNight.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(IHttpClientFactory httpClientFactory, UserManager<AppUser> userManager)
        {
            _httpClientFactory = httpClientFactory;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var client = _httpClientFactory.CreateClient();

            var categoryResponse = await client.GetAsync("https://localhost:7123/api/Category");
            if (categoryResponse.IsSuccessStatusCode)
            {
                var jsonCategoryData = await categoryResponse.Content.ReadAsStringAsync();
                var categoryValues = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonCategoryData);
                ViewBag.Categories = categoryValues.Count;
            }

            var featureResponse = await client.GetAsync("https://localhost:7123/api/Feature");
            if (featureResponse.IsSuccessStatusCode)
            {
                var jsonFeatureData = await featureResponse.Content.ReadAsStringAsync();
                var featureValues = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonFeatureData);
                ViewBag.Features = featureValues.Count;
            }

            var writerResponse = await client.GetAsync("https://localhost:7123/api/Writer");
            if (writerResponse.IsSuccessStatusCode)
            {
                var jsonWriterData = await writerResponse.Content.ReadAsStringAsync();
                var writerValues = JsonConvert.DeserializeObject<List<ResultWriterDto>>(jsonWriterData);
                ViewBag.Writers = writerValues.Count;
            }

            var bookResponse = await client.GetAsync("https://localhost:7123/api/Book");
            if (bookResponse.IsSuccessStatusCode)
            {
                var jsonBookData = await bookResponse.Content.ReadAsStringAsync();
                var bookValues = JsonConvert.DeserializeObject<List<ResultBookDto>>(jsonBookData);
                ViewBag.Books = bookValues.Count;
            }

            return View(user);
        }
    }
}
