using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics.Models
{
    public class User : DomainObject
    {
        #region ------------------------------ Properties, Indexer --------------------------------------------------

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateJoined { get; set; }

        #endregion
    }
}
