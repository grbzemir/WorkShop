using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop1.Entities.Concrete
{
    public class Instructor : BasePerson
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string NationalIdentity { get; set; }
    }
}
