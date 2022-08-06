using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppAuthAndAuth.DTO;

namespace WebAppAuthAndAuth.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        // Create a BindProperty
        [BindProperty]
        public List<WeatherForecastDTO> WeatherForecastItems { get; set; }

        private readonly IHttpClientFactory httpClientFactory;
       
        public PrivacyModel(ILogger<PrivacyModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;

            this.httpClientFactory = httpClientFactory;
        }

        public async Task OnGetAsync()
        {
            var httpClient = httpClientFactory.CreateClient("OurWebAPI");
            WeatherForecastItems = await httpClient.GetFromJsonAsync<List<WeatherForecastDTO>>("WeatherForecast");

        }
    }
}