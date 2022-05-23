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

        public User AccountHolder { get; set; }

        #endregion
    }
}
