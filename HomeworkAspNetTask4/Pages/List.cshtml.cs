using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeworkAspNetTask4.Pages
{
    public class ListModel : PageModel
    {
        public List<Country> Countries { get; set; } = new();

        public void OnGet()
        {
			Add("USA", true, true, new List<string>(new[] { "None" }), 9833520, 333287557, "Washington D.C.", "North America");
			Add("UK", true, true, new List<string>(new[] { "English" }), 242495, 66971411, "London", "Europe");
			Add("France", true, true, new List<string>(new[] { "French" }), 643801, 68042591, "Paris", "Europe");
			Add("Germany", true, true, new List<string>(new[] { "German" }), 357600, 84432670, "Berlin", "Europe");
			Add("Switzerland", true, true, new List<string>(new[] { "French", "German", "Italian", "Romansh" }), 41285, 9000064, "Bern", "Europe");
			Add("Belgium", true, true, new List<string>(new[] { "French", "German", "Dutch" }), 30528, 11697557, "Brussels", "Europe");
			Add("Australia", true, true, new List<string>(new[] { "None" }), 7692024, 26753300, "Canberra", "Oceania");
			Add("Japan", true, true, new List<string>(new[] { "Japanese" }), 377975, 125416877, "Tokyo", "Asia");
			Add("India", true, true, new List<string>(new[] { "Hindi", "English" }), 3287263, 1428627663, "New Delhi", "Asia");
			Add("People's Republic of China", true, true, new List<string>(new[] { "Mandarin Chinese" }), 9596961, 1411750000, "Beijing", "Asia");
			Add("Brazil", true, true, new List<string>(new[] { "Portugese" }), 8515767, 203062512, "Brasília", "South America");
			Add("Canada", true, true, new List<string>(new[] { "English", "French" }), 9984670, 39858480, "Ottawa", "North America");
			Add("Ukraine", true, true, new List<string>(new[] { "Ukrainian" }), 603628, 36744636, "Kyiv", "Europe");
		}

		private void Add(string name, bool independent, bool unMember, List<string> languages, int area, int population, string capital, string region)
		{
			Country country = new()
			{
				Name = name,
				Independent = independent,
				UnMember = unMember,
				Languages = languages,
				Area = area,
				Population = population,
				Capital = capital,
				Region = region
			};
			Countries.Add(country);
		}
    }
}
