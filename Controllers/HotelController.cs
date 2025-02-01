using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace MyRapidApiProject6.Controllers
{
    public class HotelController : Controller
    {
        private readonly HttpClient _httpClient;
        public HotelController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpPost]
        public async Task<IActionResult> SearchHotels(string city, int guests, string checkInDate, string checkOutDate)
        {
            var apiKey = "dc8e032bd7msh3fd61a9dde12d0dp1fbd06jsn6eb03091b85e";  // RapidAPI key'inizi buraya ekleyin
            var url = $"https://booking-com.p.rapidapi.com/v1/hotels/search?city={city}&guests={guests}&checkIn={checkInDate}&checkOut={checkOutDate}";

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers =
            {
                { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                { "X-RapidAPI-Key", apiKey }
            }
            };

            var response = await _httpClient.SendAsync(request);
            var responseBody = await response.Content.ReadAsStringAsync();

            var hotels = JObject.Parse(responseBody)["data"]["hotels"];  // JSON verisini çözümleyin

            return View(hotels);
        }
    }
}
