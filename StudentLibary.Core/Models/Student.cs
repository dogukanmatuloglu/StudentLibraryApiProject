using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Core.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Surname { get; set; }
        public string Class { get; set; }
        public int StudentNo { get; set; }

        public ICollection<Operation> Operations { get; set; }
    }
}
