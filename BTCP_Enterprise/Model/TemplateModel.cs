using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCP_Enterprise.Model
{
    internal class TemplateModel
    {


        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
         public class ProductItem
        {
            public int id { get; set; }
            public string bom_item { get; set; }
            public string description { get; set; }
            public string bom_revision_number { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
        }

        public class ProductRoot
        {
            public int current_page { get; set; }
            public List<ProductItem> data { get; set; }
            // other pagination fields if needed
        }

    }
}
