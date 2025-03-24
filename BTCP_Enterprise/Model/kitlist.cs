using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCP_Enterprise.Model
{
    public class kitlist
    {
        public class manufacturing_order
        {
            public string mo_id { get; set; }
            public string pcn_number { get; set; }
            public string description { get; set; }
            public string location { get; set; }
            public string bom_item { get; set; }
            public string bom_revision_number { get; set; }
            public string order_quantity { get; set; }
            public string order_date { get; set; }
            public string kit_date { get; set; }
            public string start_date { get; set; }
            public string end_date { get; set; }
            public List<item> manufacturing_order_items{ get; set; }
        }
            public class item
            {
                public  object mo_id { get; set; }
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
        public class items
        {
            public string mohId { get; set; }
            public string item_no { get; set; }
            public string Group { get; set; }
            public string IPN { get; set; }
            public string Description { get; set; }
            public string type { get; set; }
            public string mfg { get; set; }
            public string mfg_product_code { get; set; }
            public string srcLoc { get; set; }
            public string stock { get; set; }
            public string unit_qty { get; set; }
            public string mo_qty { get; set; }
            public string Wip_qty { get; set; }
            public string pick_qty { get; set; }
            public string short_qty { get; set; }
            public string unit { get; set; }
            public string invoice_no { get; set; }
            public string kitted { get; set; }
            public string individual_kitting { get; set; }
            public string track { get; set; }
            public string Rack { get; set; }
            public string comment { get; set; }
        }
    }
}
