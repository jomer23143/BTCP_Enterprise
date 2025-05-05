using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BTCP_Enterprise.Model
{
    internal class pre_assy
    {
        public Process preassy { get; set; }
        public item items { get; set; }
    }

    public class Process
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        [JsonProperty("process")]
        public string ProcessName { get; set; }
        public string Station { get; set; }
        public int Rev { get; set; }
    }
    public class item
    {

        public string part_serial { get; set; }
        public object mo_id { get; set; }
        public object item_number { get; set; }
        public object group { get; set; }
        public object ipn { get; set; }
        public object description { get; set; }
        public object type { get; set; }
        public object manufacturing { get; set; }
        public object manufacturing_product_code { get; set; }
        public object source_location { get; set; }
        public object stock { get; set; }
        public object unit_quantity { get; set; }
        public object mo_quantity { get; set; }
        public object wip_quantity { get; set; }
        public object pick_quantity { get; set; }
        public object short_quantity { get; set; }
        public object unit { get; set; }
        public object invoice_number { get; set; }
        public object kitted { get; set; }
        public object individual_kitting { get; set; }
        public object track { get; set; }
        public object rack { get; set; }
        public object comment { get; set; }
    }

}
