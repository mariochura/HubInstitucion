using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Exceptions;

namespace Domain.Entities
{
    public class Branch
    {
        public int id { get; set; }
        
        public string name { get; private set;
        }
        public int organization_id { get; set; }

        public Branch(int id, string name, int organizationId)
        {
            this.id = id;
            if (string.IsNullOrEmpty(name)) throw new InvalidNameArgument();
            this.name = name;
            organization_id = organizationId;
        }
    }
}
