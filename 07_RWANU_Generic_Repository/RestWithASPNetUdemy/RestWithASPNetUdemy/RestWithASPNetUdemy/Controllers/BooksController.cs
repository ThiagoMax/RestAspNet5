﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNetUdemy.Model;
using RestWithASPNetUdemy.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RWANU.Model;

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
        public IActionResult Get()
        {
            return Ok(_booksBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var book = _booksBusiness.FindById(id);
            if(book == null) return NotFound();
            return Ok(book);
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Books book)
        {
            if(book == null) return BadRequest();
            return Ok(_booksBusiness.Create(book));
        }
        
        [HttpPut]
        public IActionResult Put([FromBody] Books book)
        {
            if(book == null) return BadRequest();
            return Ok(_booksBusiness.Update(book));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _booksBusiness.Delete(id);
            return NoContent();
        }
    }
}
