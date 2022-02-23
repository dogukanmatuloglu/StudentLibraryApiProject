using Microsoft.EntityFrameworkCore;
using StudentLibrary.Core.Models;
using StudentLibrary.Core.Repositories;
using StudentLibrary.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Data.Repositories
{
    public class OperationRepository:GenericRepository<Operation>,IOperationRepository
    {
        public OperationRepository(StudentLibraryContext dbContext) : base(dbContext)
        {

        }
    }
}
