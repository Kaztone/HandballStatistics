using System;

namespace HandballStatistics.Models
{
    /// <summary>
    /// Base class for Shot.
    /// Derives from <see cref="DomainObject"/> class.
    /// </summary>
    public class Shot : DomainObject
    {
        #region-----------------------------Properties, Indexer--------------------------------
        /// <summary>
        /// Gets or sets MatchId.
        /// </summary>
        public int MatchId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a Goal was scored or not.
        /// </summary>
        public bool Goal { get; set; }

        /// <summary>
        /// Gets or sets SquareNumber.
        /// </summary>
        public int SquareNumber { get; set; }

        /// <summary>
        /// Gets or sets Time.
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets PlayerId.
        /// </summary>
        public int PlayerId { get; set; }

        /// <summary>
        /// Gets or sets TeamId.
        /// </summary>
        public int TeamId { get; set; }
        #endregion
    }
}
