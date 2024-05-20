using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Exceptions;

namespace Domain.Entities
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string Campus { get; set; }
        public string Acronym { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public DateTime DateCreation { get; set; } 
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        
        public Branch(int id, string name, int organizationId)
        {
            this.Id = id;
            if (string.IsNullOrEmpty(name)) throw new InvalidNameArgument();
            this.Name = name;
            OrganizationId = organizationId;
            
        }
    }
}
