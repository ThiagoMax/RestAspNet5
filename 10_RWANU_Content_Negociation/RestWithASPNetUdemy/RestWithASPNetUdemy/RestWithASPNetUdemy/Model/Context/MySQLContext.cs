﻿using Microsoft.EntityFrameworkCore;
using RWANU.Model;

namespace RestWithASPNetUdemy.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Books> Books { get; set; }
    }
}
