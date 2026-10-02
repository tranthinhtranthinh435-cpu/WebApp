namespace WebApp.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; // diesel, gear, gasoline
        public string CategoryName { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Viscosity { get; set; } = string.Empty;
        public string Packaging { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Badge { get; set; } = string.Empty;
    }
}
