using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics.Models
{
    public class Player : DomainObject
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int JerseyNumber { get; set; }

        public int Goals { get; set; }

        public int TeamId { get; set; }

        public string FullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
