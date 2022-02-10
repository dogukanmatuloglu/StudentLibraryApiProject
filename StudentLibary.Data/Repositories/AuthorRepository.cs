using Microsoft.EntityFrameworkCore;
using StudentLibrary.Core.Models;
using StudentLibrary.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Data.Repositories
{
    class AuthorRepository :GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(DbContext dbContext):base(dbContext)
        {

        }
    }
}
