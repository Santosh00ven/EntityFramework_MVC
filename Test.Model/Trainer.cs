using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Model
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //[DataType(DataType.Date)] for core
        [Column(TypeName="Date") ]
        public DateTime DateofBirth { get; set; }
        public string PhoneNumber { get; set; }
    }
}
