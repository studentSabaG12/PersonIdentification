using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonIdentification.DTO
{
    internal class City
    {
        public string Id {  get; set; }
        public string Name { get; set; }
        public ICollection<Person> Persons { get; set;}
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }

    }
}
