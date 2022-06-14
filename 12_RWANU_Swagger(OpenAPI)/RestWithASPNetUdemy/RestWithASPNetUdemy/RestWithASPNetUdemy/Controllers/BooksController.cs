using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNetUdemy.Model;
using RestWithASPNetUdemy.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RWANU.Model;
using RWANU.Data.VO;
using RWANU.Hypermedia.Filters;

namespace RestWithASPNetUdemy.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private IBooksBusiness _booksBusiness;

        public BooksController(ILogger<BooksController> logger, IBooksBusiness bookBusiness)
        {
            _logger = logger;
            _booksBusiness = bookBusiness;
        }

        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<BooksVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_booksBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(BooksVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var book = _booksBusiness.FindById(id);
            if(book == null) return NotFound();
            return Ok(book);
        }
        
        [HttpPost]
        [ProducesResponseType((200), Type = typeof(BooksVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] BooksVO book)
        {
            if(book == null) return BadRequest();
            return Ok(_booksBusiness.Create(book));
        }
        
        [HttpPut]
        [ProducesResponseType((200), Type = typeof(BooksVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] BooksVO book)
        {
            if(book == null) return BadRequest();
            return Ok(_booksBusiness.Update(book));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(long id)
        {
            _booksBusiness.Delete(id);
            return NoContent();
        }
    }
}
