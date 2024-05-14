using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Nit { get; set; }
        public string Logo { get; set; }
        public string Date_Creation { get; set; }
        public string Municipality { get; set; }= "";
        public string Acronym { get; set; }= "";

        public Organization()
        {
        }
    }
}
