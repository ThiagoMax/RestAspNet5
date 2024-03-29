﻿using RWANU.Data.Converter.Contract;
using RWANU.Data.VO;
using RWANU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RWANU.Data.Converter.Implementations
{
    public class BooksConverter : IParser<BooksVO, Books>, IParser<Books, BooksVO>
    {
        public Books Parse(BooksVO origin)
        {
            if (origin == null) return null;
            return new Books
            {
                Author = origin.Author,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Title = origin.Title
            };
        }

        public BooksVO Parse(Books origin)
        {
            if (origin == null) return null;
            return new BooksVO
            {
                Author = origin.Author,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Title = origin.Title
            };
        }

        public List<Books> Parse(List<BooksVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<BooksVO> Parse(List<Books> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
