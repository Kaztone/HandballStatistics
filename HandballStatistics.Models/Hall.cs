namespace HandballStatistics.Models
{
    public class Hall : DomainObject
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int CountryId { get; set; }
    }
}
