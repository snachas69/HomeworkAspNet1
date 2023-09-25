using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeworkAspNetTask2.Pages
{
    public class ListModel : PageModel
    {
        public List<Restaurant> Restaurants { get; set; } = new();

        public void OnGet()
        {
            Add("Tasty Bites", "123 Main Street, Cityville", "(123) 456-7890", "https://www.tastybites.com");
            Add("Spice Garden", "456 Oak Avenue, Townsville", "(456) 789-1234", "https://www.spicegarden.com");
            Add("Cafe Italia", "789 Elm Road, Villageton", "(789) 123-5678", "https://www.cafeitalia.com");
            Add("Sushi Fusion", "101 Pine Street, Seaside", "(101) 234-5678", "https://www.sushifusion.com");
            Add("Mama's Kitchen", "321 Maple Lane, Riverside", "(321) 567-8901", "https://www.mamaskitchen.com");
            Add("The Steakhouse", "555 Oak Road, Townsville", "(555) 678-9012", "https://www.thesteakhouse.com");
            Add("Pizza Paradise", "777 Cedar Street, Beachtown", "(777) 890-1234", "https://www.pizzaparadise.com");
            Add("Noodle World", "999 Birch Avenue, Lakeside", "(999) 345-6789", "https://www.noodleworld.com");
            Add("BBQ Haven", "888 Pine Street, Hillside", "(888) 456-7890", "https://www.bbqhaven.com");
            Add("Vegan Delights", "666 Elm Road, Greenfield", "(666) 567-8901", "https://www.vegandelights.com");
        }

        private void Add(string name, string location, string phone, string webSite)
        {
            Restaurants.Add(new Restaurant { Name = name, Location = location,Phone = phone, WebSite = webSite });
        }
    }
}
