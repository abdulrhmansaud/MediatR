using Microsoft.EntityFrameworkCore;
using Mediator.Model;

namespace Mediator.Dbconnection
{
    public class Dbconnect : DbContext
    {
        public Dbconnect(DbContextOptions<Dbconnect> opt) :base(opt) {

        }
       public DbSet<book> books { get; set;}
    
    }
}