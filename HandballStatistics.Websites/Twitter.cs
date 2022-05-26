using HandballStatistics.Interfaces.Models;

namespace HandballStatistics.Websites
{
    public class Twitter : WebsiteBase
    {
        public override string Name { get; set; }

        public override string URL { get; set; }

        public Twitter()
        {
            this.Name = "Twitter";
            this.URL = "https://twitter.com/?lang=en";
        }
    }
}
