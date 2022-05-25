using RestWithASPNetUdemy.Model.Context;
using RWANU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNetUdemy.Repository.Implementations
{
    public class BooksRepositoryImplementation : IBooksRepository
    {
        private MySQLContext _context;
        
        public BooksRepositoryImplementation(MySQLContext context) 
        {
            _context = context;
        }

        public List<Books> FindAll()
        {
            return _context.Books.ToList();
        }

        public Books FindById(long id)
        {
            return _context.Books.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Books Create(Books book)
        {
            try
            {
                _context.Add(book);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return book;
        }

        public Books Update(Books book)
        {
            if (!Exists(book.Id)) return new Books();

            var result = _context.Books.SingleOrDefault(p => p.Id.Equals(book.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(book);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return book;
        }

        public void Delete(long id)
        {
            var result = _context.Books.SingleOrDefault(p => p.Id.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return _context.Books.Any(p => p.Id.Equals(id));
        }
    }
}
