using HandballStatistics.Interfaces.Models;

namespace HandballStatistics.Websites
{
    public class Facebook : WebsiteBase
    {
        public override string Name { get; set; }

        public override string URL { get; set; }

        public Facebook()
        {
            this.Name = "Facebook";
            this.URL = "https://de-de.facebook.com/";            
        }
    }
}
