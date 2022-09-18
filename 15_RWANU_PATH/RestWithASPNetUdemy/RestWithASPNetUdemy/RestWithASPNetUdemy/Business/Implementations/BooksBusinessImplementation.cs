using RestWithASPNetUdemy.Model;
using RestWithASPNetUdemy.Model.Context;
using RestWithASPNetUdemy.Repository;
using RWANU.Data.Converter.Implementations;
using RWANU.Data.VO;
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
        private readonly IPersonRepository<Books> _repository;
        private readonly BooksConverter _converter;
        
        public BooksBusinessImplementation(IPersonRepository<Books> repository) 
        {
            _repository = repository;
            _converter = new BooksConverter();
        }

        public List<BooksVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public BooksVO FindById(long id)
        {

            return _converter.Parse(_repository.FindById(id));
        }

        public BooksVO Create(BooksVO book)
        {
            var booksEntity = _converter.Parse(book);
            booksEntity = _repository.Create(booksEntity);
            return _converter.Parse(booksEntity);
        }

        public BooksVO Update(BooksVO book)
        {
            var booksEntity = _converter.Parse(book);
            booksEntity = _repository.Update(booksEntity);
            return _converter.Parse(booksEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
