using dataExtraction.Domain.entities.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataExtraction.Domain.entities
{
    public class User : MainEntities
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }

    }
}
