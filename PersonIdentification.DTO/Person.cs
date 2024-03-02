using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonIdentification.DTO
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName {  get; set; }
        public PersonGender Gender { get; set; }
        public string PersonalNumber {  get; set; }
        public Number Number { get; set; }
        public City City { get; set; }
        public DateTime BirthDate {  get; set; }
        public ICollection<Number> Numbers { get; set; }
        public ICollection<RefferencedPersons> Refpersons { get; set;}
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
    }
    public enum PersonGender : byte
    {
        Male = 0,
        Female = 1
    }
}
