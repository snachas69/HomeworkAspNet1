namespace HomeworkAspNetTask4
{
	public class Country
	{
		public string? Name { get; set; }
		public bool Independent { get; set; }
		public bool UnMember { get; set; }
		public string? Capital { get; set; }
		public string? Region { get; set; }
		public int Population { get; set; }
		public int Area { get; set; }
		public List<string> Languages { get; set; } = new();
	}
}
