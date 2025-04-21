using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCP_Enterprise.Model
{
    public class Serial
    {
        public int id { get; set; }
        public int kit_list_item_id { get; set; }
        public int kit_list_item_serial_number_status_id { get; set; }
        public string kit_list_part_serial_number { get; set; }
        public int is_scan { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object status { get; set; }
    }

    public class Status
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string color { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class KitListItem
    {
        public int id { get; set; }
        public int kit_list_id { get; set; }
        public string mo_id { get; set; }
        public string group { get; set; }
        public string ipn { get; set; }
        public string description { get; set; }
        public int mo_quantity { get; set; }
        public int pick_quantity { get; set; }
        public List<Serial> serial { get; set; }
        public Status status { get; set; }
    }

    public class Root
    {
        public int current_page { get; set; }
        public List<KitListItem> data { get; set; }
        public string first_page_url { get; set; }
        public int total { get; set; }
    }

}
