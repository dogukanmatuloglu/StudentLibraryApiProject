using StudentLibrary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Core.Dtos
{
    public class AuthorDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
