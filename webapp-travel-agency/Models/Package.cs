namespace webapp_travel_agency.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? NumberOfDays { get; set; }
        public int? NumberOfDestinations { get; set; }
        public double? Price { get; set; }

        public Package()
        {
        }
    }
}
