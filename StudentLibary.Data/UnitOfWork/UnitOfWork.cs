using StudentLibrary.Core.Repositories;
using StudentLibrary.Core.UnitOfWork;
using StudentLibrary.Data.Contexts;
using StudentLibrary.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentLibraryContext _context;
        private AuthorRepository _authorRepository;
        private BookRepository _bookRepository;
        private StudentRepository _studentRepository;
        private OperationRepository _operationRepository;

        public UnitOfWork(StudentLibraryContext context)
        {
            _context = context;
        }

        public IAuthorRepository Authors => _authorRepository ?? new AuthorRepository(_context);

        public IBookRepository Books => _bookRepository ?? new BookRepository(_context);

        public IStudentRepository Students => _studentRepository ?? new StudentRepository(_context);

        public IOperationRepository Operations => _operationRepository ?? new OperationRepository(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
