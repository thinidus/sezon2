using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crmAppBL
{
    public class PrintOrder
    {

        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTimeOffset? OrderDate { get; set; }
        public List<PrintOrderPosition> PrintOrderPositions { get; set; }
        public int OrderID { get; set; }
        public Address OrderAddres { get; set; }


    }
}
