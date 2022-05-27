using System;

namespace HandballStatistics.Models
{
    /// <summary>
    /// Base class for Shot.
    /// Derives from <see cref="DomainObject"/> class.
    /// </summary>
    public class User : DomainObject
    {
        #region ------------------------------ Properties, Indexer --------------------------------------------------

        /// <summary>
        /// Gets or sets UserName.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets DateJoined.
        /// </summary>
        public DateTime DateJoined { get; set; }

        #endregion
    }
}
