namespace HandballStatistics.Models
{
    /// <summary>
    /// Base class for Hall.
    /// Derives from <see cref="DomainObject"/> class.
    /// </summary>
    public class Hall : DomainObject
    {
        #region-----------------------------Properties, Indexer--------------------------------
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets CountryId.
        /// </summary>
        public int CountryId { get; set; }
        #endregion
    }
}
