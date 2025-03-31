using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCP_Enterprise.Model
{
    internal class TestModel
    {

        public class serial_number
        {
            public string id { get; set; }
            public string part_serial { get; set; }
        }

        public class add_serial_number
        {
            public List<serial_number> kit_list_items { get; set; }

        }
    }
}
