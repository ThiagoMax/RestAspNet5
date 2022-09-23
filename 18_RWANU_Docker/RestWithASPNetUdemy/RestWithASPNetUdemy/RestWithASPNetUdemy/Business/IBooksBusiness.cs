using RestWithASPNetUdemy.Model;
using RWANU.Data.VO;
using RWANU.Model;
using System.Collections.Generic;

namespace RestWithASPNetUdemy.Business
{
    public interface IBooksBusiness
    {
        BooksVO Create(BooksVO book);
        BooksVO FindById(long id);
        List<BooksVO> FindAll();
        BooksVO Update(BooksVO book);
        void Delete(long id);
    }
}
