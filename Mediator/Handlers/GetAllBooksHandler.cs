using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Mediator.Data;
using Mediator.Dtos;
using Mediator.Queries;
using MediatR;


namespace Mediator.Handlers
{
    public class GetAllBooksHandler : IRequestHandler<GetAllBooksQuery, List<BookReadDto>>
    {
        private readonly IBookRepo _repository; 
        private readonly IMapper _mapper; 
        public GetAllBooksHandler(IBookRepo repository, IMapper mapper){

            _mapper = mapper; 
            _repository = repository;

        }

        public async Task<List<BookReadDto>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {

            var getAllBook =  await _repository.GetAllBooks();
            return _mapper.Map<List<BookReadDto>>(getAllBook);
        }
    }
}