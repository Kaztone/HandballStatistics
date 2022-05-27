using System.Collections.Generic;

namespace HandballStatistics.Models
{
    /// <summary>
    /// Base class for League.
    /// Derives from <see cref="DomainObject"/> class.
    /// </summary>
    public class League : DomainObject
    {
        #region-----------------------------Properties, Indexer--------------------------------
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Abbrevation.
        /// </summary>
        public string Abbrevation { get; set; }

        /// <summary>
        /// Gets or sets CountryId.
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets Teams.
        /// </summary>
        public ICollection<Team> Teams { get; set; }
        #endregion
    }
}
