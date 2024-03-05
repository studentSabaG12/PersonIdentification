using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonIdentification.DTO
{
    public class RefferencedPersons
    {
        public int Id { get; set; }
        public int PersonId {  get; set; }
        public Person Person {  get; set; }
        public string ConnectionType { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
