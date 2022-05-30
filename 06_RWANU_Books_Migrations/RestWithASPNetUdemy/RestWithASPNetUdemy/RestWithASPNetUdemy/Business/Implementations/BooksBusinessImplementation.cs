using RestWithASPNetUdemy.Model;
using RestWithASPNetUdemy.Model.Context;
using RestWithASPNetUdemy.Repository;
using RWANU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNetUdemy.Business.Implementations
{
    public class BooksBusinessImplementation : IBooksBusiness
    {
        private readonly IBooksRepository _repository;
        
        public BooksBusinessImplementation(IBooksRepository repository) 
        {
            _repository = repository;
        }

        public List<Books> FindAll()
        {
            return _repository.FindAll();
        }

        public Books FindById(long id)
        {

            return _repository.FindById(id);
        }

        public Books Create(Books book)
        {
            return _repository.Create(book);
        }

        public Books Update(Books book)
        {
            return _repository.Update(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
