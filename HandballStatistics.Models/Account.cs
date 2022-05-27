namespace HandballStatistics.Models
{ 
    /// <summary>
    /// Base class for Account.
    /// Derives from <see cref="DomainObject"/> class.
    /// </summary>
    public class Account : DomainObject
    {
        #region-----------------------------Constructor,Destrucor,Dispose,Clone----------------
        /// <summary>
        /// Prevents a default instance of the <see cref="Account"/> class from being created.>
        /// Initializes a new instance of the <see cref="HandballStatistics.Models.Account" /> class. 
        /// </summary>
        /// <param name="user">User the current Account belongs to</param>
        public Account(User user) : base()
        {
            this.AccountHolder = user;
            this.AccountHolderId = user.Id;
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="Account"/> class from being created.
        /// Initializes a new instance of the <see cref="HandballStatistics.Models.Account" /> class. 
        /// </summary>
        private Account() 
        {
        }
        #endregion

        #region-----------------------------Properties, Indexer--------------------------------
        /// <summary>
        /// Gets or sets AccountHolderId.
        /// </summary>
        public int AccountHolderId { get; set; }

        /// <summary>
        /// Gets or sets AccountHolder.
        /// </summary>
        public User AccountHolder { get; set; }

        #endregion
    }
}
