using StudentLibrary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Core.Dtos
{
    public class OperationUpdateDto
    {
        public int Id { get; set; }
        public DateTime TDate { get; set; }
        public DateTime GDate { get; set; }
        public Student Student { get; set; }
        public Book Book { get; set; }
    }
}
