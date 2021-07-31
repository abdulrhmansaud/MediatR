using System;
using System.Collections.Generic;
using Mediator.Dtos;
using MediatR;

namespace Mediator.Queries
{
    public class GetBooksByIdQuery : IRequest<BookReadDto>
    {

        public int Id{ get; }
        public GetBooksByIdQuery(int id)
        {
           Id = id ;
        }
    }
}