﻿using RWANU.Model;
using System.Collections.Generic;

namespace RestWithASPNetUdemy.Repository
{
    public interface IBooksRepository
    {
        Books Create(Books book);
        Books FindById(long id);
        List<Books> FindAll();
        Books Update(Books book);
        void Delete(long id);

        bool Exists(long id);
    }
}
