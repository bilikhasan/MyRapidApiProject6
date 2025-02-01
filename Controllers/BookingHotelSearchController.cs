using Microsoft.AspNetCore.Mvc;
using MyRapidApiProject6.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;


namespace MyRapidApiProject6.Controllers
{
    public class BookingHotelSearchController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string p, string dateIn, string dateOut, int guest, int children)
        {

            if (string.IsNullOrEmpty(p) || string.IsNullOrEmpty(dateIn) || string.IsNullOrEmpty(dateOut))
            {
                return View();
            }

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={p}"),
                Headers =
                {
                    { "x-rapidapi-key", "API KEY BURAYA YAZILACAK" },
                    { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var destinationResponse = JsonConvert.DeserializeObject<DestinationResponse>(body);
                var destinationId = destinationResponse?.data?.Count > 0 ? destinationResponse.data[0].dest_id : null;

                if (destinationId == null)
                {

                    return View();
                }


                return RedirectToAction("BookHotelSearch", new { destId = destinationId, dateIn, dateOut, guest, children });
            }
        }

        [HttpGet]
        public async Task<IActionResult> BookHotelSearch(string destId, string dateIn, string dateOut, int guest, int children)
        {
            if (string.IsNullOrEmpty(destId) || string.IsNullOrEmpty(dateIn) || string.IsNullOrEmpty(dateOut))
            {
                return BadRequest("Geçersiz arama parametreleri.");
            }

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id={destId}&search_type=CITY&arrival_date={dateIn}&departure_date={dateOut}&adults={guest}&children_age={children}&room_qty=1&page_number=1&units=metric&temperature_unit=c&languagecode=en-us&currency_code=AED"),
                Headers =
                {
                    { "x-rapidapi-key", "API KEY BURAYA YAZILACAK" },
                    { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var apiResponse = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(body);
                var hotels = apiResponse?.data?.hotels?.ToList() ?? new List<BookingHotelSearchViewModel.Hotel>();

                return View(hotels);
            }
        }
    }
}
