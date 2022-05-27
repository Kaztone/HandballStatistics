namespace HandballStatistics.Models
{
    /// <summary>
    /// Base class for Player.
    /// Derives from <see cref="DomainObject"/> class.
    /// </summary>
    public class Player : DomainObject
    {      
        #region-----------------------------Properties, Indexer--------------------------------
        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets JerseyNumber.
        /// </summary>
        public int JerseyNumber { get; set; }

        /// <summary>
        /// Gets or sets Goals.
        /// </summary>
        public int Goals { get; set; }

        /// <summary>
        /// Gets or sets TeamId.
        /// </summary>
        public int TeamId { get; set; }
        #endregion

        #region-----------------------------Methods--------------------------------------------
        /// <summary>
        /// Creates <see cref="Player"/> full name.
        /// </summary>
        /// <returns>Full <see cref="Player"/> name.</returns>
        /// <remarks></remarks>
        public string FullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }
        #endregion
    }
}
