using System.Collections.Generic;
using Mediator.Dtos;
using MediatR;

namespace Mediator.Queries
{
    public class GetAllBooksQuery : IRequest<List<BookReadDto>>
    {
        
    }
}