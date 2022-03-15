using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_Assessement_V01.Models;
namespace Technical_Assessement_V01.Data
{
    public class App_DBContext:DbContext
    {
        public App_DBContext(DbContextOptions<App_DBContext>options):base(options)
        {

        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
