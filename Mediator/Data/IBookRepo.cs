using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mediator.Commands;
using Mediator.Model;

namespace Mediator.Data
{
    public interface IBookRepo
    {  
     bool SaveChanges();     
     public Task<IEnumerable<book>> GetAllBooks();
     public Task<book> GetBookById(int id);
      Task CreateBooks(book books);

    }
}