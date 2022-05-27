namespace HandballStatistics.Websites
{
    /// <summary>
    /// Base class for Facebook.
    /// Derives from <see cref="WebsiteBase"/> class.
    /// </summary>
    public class Facebook : WebsiteBase
    {
        #region-----------------------------Constructor,Destrucor,Dispose,Clone----------------       
        /// <summary>
        /// Prevents a default instance of the <see cref="Instagram"/> class from being created.
        /// Initializes a new instance of the <see cref="HandballStatistics.Websites.Facebook" /> class. 
        /// </summary>
        public Facebook()
        {
            this.Name = "Facebook";
            this.URL = "https://de-de.facebook.com/";
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
