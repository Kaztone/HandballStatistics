using System;
using System.Collections.Generic;

namespace HandballStatistics.Models
{
    /// <summary>
    /// Base class for Match.
    /// Derives from <see cref="DomainObject"/> class.
    /// </summary>
    public class Match : DomainObject
    {
        #region-----------------------------Properties, Indexer--------------------------------
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets FileName.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets Shots.
        /// </summary>
        public ICollection<Shot> Shots { get; set; }
        #endregion
    }
}
