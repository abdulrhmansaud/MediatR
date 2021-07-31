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
    public class GetBooksByIdHandler : IRequestHandler<GetBooksByIdQuery, BookReadDto>
    {
        private readonly IBookRepo _repository; 
        private readonly IMapper _mapper; 
        public GetBooksByIdHandler(IBookRepo repository, IMapper mapper){

            _mapper = mapper; 
            _repository = repository;

        }
        public async Task<BookReadDto> Handle(GetBooksByIdQuery request, CancellationToken cancellationToken)
        {
            var getbyid = await _repository.GetBookById(request.Id);
            if(getbyid == null){
                return null;
            }
       
            return _mapper.Map<BookReadDto>(getbyid);
        }

    }
}