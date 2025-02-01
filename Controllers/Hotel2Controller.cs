using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace MyRapidApiProject6.Controllers
{
    public class Hotel2Controller : Controller
    {
        [HttpGet]
        public IActionResult SearchHotels2()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchHotels2(string city, string checkin, string checkout, int guests)
        {
            // API URL'si
            string apiUrl = "https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id=2309&search_type=district&arrival_date=2025-01-27&departure_date=2025-01-30&adults=2&children_age=0%2C17&room_qty=1&page_number=1&units=metric&temperature_unit=c&languagecode=en-us&currency_code=USD";

            // RapidAPI Anahtar
            string apiKey = "dc8e032bd7msh3fd61a9dde12d0dp1fbd06jsn6eb03091b85e";

            using (HttpClient client = new HttpClient())
            {
                // API Header bilgileri
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", apiKey);
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "booking-com.p.rapidapi.com");

                // Dinamik olarak URL oluşturma
                string queryString = $"?city_name={city}&checkin_date={checkin}&checkout_date={checkout}&adults_number={guests}&locale=en-us";
                HttpResponseMessage response = await client.GetAsync(apiUrl + queryString);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // JSON'u dinamik olarak parse et
                    dynamic hotels = JObject.Parse(jsonResponse);

                    // Otel verilerini kontrol et
                    if (hotels.property != null)
                    {
                        // View'e otel listesini gönder
                        return View("HotelList", hotels.property);
                    }
                    else
                    {
                        ViewBag.Error = "Otel bilgisi alınamadı.";
                        return View("Error");
                    }
                }
                else
                {
                    ViewBag.Error = "API çağrısı başarısız oldu.";
                    return View("Error");
                }
            }
        }
    }
}
