using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Mediator.Commands;
using Mediator.Data;
using Mediator.Dtos;
using Mediator.Model;
using MediatR;

namespace Mediator.Handlers
{
    public class CreateBooksHandler : IRequestHandler<CreateBookCommands, BookReadDto>
    {

        private readonly IBookRepo _repository; 
        private readonly IMapper _mapper; 
        public CreateBooksHandler(IBookRepo repository, IMapper mapper){

            _mapper = mapper; 
            _repository = repository;

        }

        public async Task<BookReadDto> Handle(CreateBookCommands request, CancellationToken cancellationToken)
        {
          book books = new book(); 
          books.Title = request.Title;
          books.Description = request.Description;
          books.Author = request.Author;
          books.availability = request.availability;
          await _repository.CreateBooks(books);
           _repository.SaveChanges();
          return _mapper.Map<BookReadDto>(books);

          
           
        }
    }
}