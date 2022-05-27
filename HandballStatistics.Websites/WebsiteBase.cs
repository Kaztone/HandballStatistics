using HandballStatistics.Interfaces.Models;

namespace HandballStatistics.Websites
{
    /// <summary>
    /// Base class for WebsiteBase.
    /// Derives from <see cref="IWebsite"/> class.
    /// </summary>
    public abstract class WebsiteBase : IWebsite
    {
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public abstract string Name { get; set; }

        /// <summary>
        /// Gets or sets URL.
        /// </summary>
        public abstract string URL { get; set; }
    }
}
