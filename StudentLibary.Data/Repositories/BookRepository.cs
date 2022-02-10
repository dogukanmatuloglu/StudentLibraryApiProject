using Microsoft.EntityFrameworkCore;
using StudentLibrary.Core.Models;
using StudentLibrary.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Data.Repositories
{
    public class BookRepository:GenericRepository<Book>,IBookRepository
    {
        public BookRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
