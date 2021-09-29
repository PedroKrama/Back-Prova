using Microsoft.EntityFrameworkCore;
using API_Prova.Models;
using System.Linq;
using System;

namespace API_Prova.Data
{
    public class DataContext : DbContext
    {
        
         public DataContext(DbContextOptions<DataContext> options) : base(options) {}

         
            public DbSet<Livro> Livros { get; set;}
        
     }      
}
         
