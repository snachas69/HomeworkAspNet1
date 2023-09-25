using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeworkAspNetTask3.Pages
{
    public class ResturantModel : PageModel
    {
		public string RestaurantName { get; set; }
		public string Location { get; set; }
		public string Phone { get; set; }
		public string Website { get; set; }

		public void OnGet()
		{
			RestaurantName = "Delicious Delights";
			Location = "123 Main Street, Cityville";
			Phone = "(123) 456-7890";
			Website = "https://www.example.com";
		}
	}
}
