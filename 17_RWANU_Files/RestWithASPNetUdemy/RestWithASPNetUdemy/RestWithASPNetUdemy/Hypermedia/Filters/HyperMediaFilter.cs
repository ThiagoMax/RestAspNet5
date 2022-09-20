using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RWANU.Hypermedia.Filters
{
    public class HyperMediaFilter : ResultFilterAttribute
    {
        private readonly HyperMediaFiltersOptions _hyperMediaFiltersOptions;

        public HyperMediaFilter(HyperMediaFiltersOptions hyperMediaFiltersOptions)
        {
            _hyperMediaFiltersOptions = hyperMediaFiltersOptions;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            TryEnrichResult(context);
            base.OnResultExecuting(context);
        }

        private void TryEnrichResult(ResultExecutingContext context)
        {
            if (context.Result is OkObjectResult objectResult)
            {
                var enricher = _hyperMediaFiltersOptions
                    .ContentResponseEnricherList
                    .FirstOrDefault(x => x.CanEnrich(context));

                if (enricher != null) Task.FromResult(enricher.Enrich(context));
            };
        }
    }
}
