using RWANU.Hypermedia;
using RWANU.Hypermedia.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RWANU.Data.VO
{
    public class BooksVO : ISupportHypermedia
    {
        public long Id { get; set; }
        
        public string Author { get; set; }

        public DateTime LaunchDate { get; set; }

        public decimal Price { get; set; }

        public string Title { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
