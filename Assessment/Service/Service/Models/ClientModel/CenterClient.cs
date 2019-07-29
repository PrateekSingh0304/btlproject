using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Center
    {
        public int CenterId { get; set; }
        public string CenterName { get; set; }
        public string CenterCode{ get; set; }
        public string Address { get; set; }

        public int PersonID { get; set; }
        public string PersonName { get; set; }
    }
}
