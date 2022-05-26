using HandballStatistics.Interfaces.Models;

namespace HandballStatistics.Websites
{
    public abstract class WebsiteBase : IWebsite
    {
        public abstract string Name { get; set; }
        public abstract string URL { get; set; }
    }
}
