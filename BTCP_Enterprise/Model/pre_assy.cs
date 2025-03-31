using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCP_Enterprise.Model
{
    internal class pre_assy
    {
        public Process preassy { get; set; }
    }

    public class Process
    {
        public int id { get; set; }
        public string id_no { get; set; }
        public string process { get; set; }
        public string station { get; set; }
        public string rev { get; set; }
    }

}
