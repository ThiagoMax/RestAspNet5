﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RWANU.Model
{
    [Table("books")]
    public class Books
    {
        [Column("id")]
        public long Id { get; set; }
        
        [Column("author")]
        public string Author { get; set; }
        
        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
        
        [Column("price")]
        public decimal Price { get; set; }
        
        [Column("title")]
        public string Title { get; set; }
    }
}
