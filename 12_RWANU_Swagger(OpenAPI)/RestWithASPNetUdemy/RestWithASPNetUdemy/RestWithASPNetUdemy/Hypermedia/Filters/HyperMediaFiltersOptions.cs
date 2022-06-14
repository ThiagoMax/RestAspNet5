using RWANU.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RWANU.Hypermedia.Filters
{
    public class HyperMediaFiltersOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
