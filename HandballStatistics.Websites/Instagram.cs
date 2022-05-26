using HandballStatistics.Interfaces.Models;

namespace HandballStatistics.Websites
{
    public class Instagram : WebsiteBase
    {
        public override string Name { get; set; }

        public override string URL { get; set; }

        public Instagram()
        {
            this.Name = "Instagram";
            this.URL = "https://www.instagram.com/";
        }
    }
}
