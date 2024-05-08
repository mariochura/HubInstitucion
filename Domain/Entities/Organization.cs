using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Organization
    {
        public int id { get; set; }
        public string name { get; set; } = "";
        public string address { get; set; }= "";
        public string municipality { get; set; }= "";
        public string acronym { get; set; }= "";

        public Organization()
        {
        }
    }
}
