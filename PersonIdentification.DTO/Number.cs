using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonIdentification.DTO
{
    public class Number
    {

        public int Id { get; set; }
        public NumberType numberType { get; set; }
        [MinLength(4, ErrorMessage = "Number must be at least 4 characters long.")]
        [MaxLength(50, ErrorMessage = "Number cannot exceed 50 characters.")]
        public string TextNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }

        public enum NumberType : byte 
        {
            Mobilephone = 0,
            Officenumber = 1,
            HouseNumber = 2


        }

    }
}