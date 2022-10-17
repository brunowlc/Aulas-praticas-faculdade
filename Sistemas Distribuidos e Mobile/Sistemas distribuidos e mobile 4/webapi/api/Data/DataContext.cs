using System;
using System.Net.Mime;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

        public DbSet<Filme> Filmes { get; set; }
    }
}