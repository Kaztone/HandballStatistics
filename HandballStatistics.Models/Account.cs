using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics.Models
{
    public class Account : DomainObject
    {
        #region ------------------------------ Properties, Indexer --------------------------------------------------

        public int AccountHolderId { get; set; }

        public User AccountHolder { get; set; }

        #endregion

        private Account()
        {
            
        }

        public Account(User user) : base()
        {
            this.AccountHolder = user;
            this.AccountHolderId = user.Id;
        }
    }
}
