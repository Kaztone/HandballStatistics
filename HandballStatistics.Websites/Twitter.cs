namespace HandballStatistics.Websites
{
    /// <summary>
    /// Base class for Twitter.
    /// Derives from <see cref="WebsiteBase"/> class.
    /// </summary>
    public class Twitter : WebsiteBase
    {
        #region-----------------------------Constructor,Destrucor,Dispose,Clone----------------       
        /// <summary>
        /// Prevents a default instance of the <see cref="Twitter"/> class from being created.
        /// Initializes a new instance of the <see cref="HandballStatistics.Websites.Twitter" /> class. 
        /// </summary>
        public Twitter()
        {
            this.Name = "Twitter";
            this.URL = "https://twitter.com/?lang=en";
        }
        #endregion

        #region-----------------------------Properties, Indexer--------------------------------
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Gets or sets URL.
        /// </summary>
        public override string URL { get; set; }
        #endregion        
    }
}
