using AutoMapper;
using Mediator.Dtos;
using Mediator.Model;

namespace Mediator.Profiles
{
    public class BooksProfiles : Profile
    {
        public BooksProfiles(){
 
          CreateMap<book,BookReadDto>();
          CreateMap<BookCreateDto,book>();
           

        }
    }
}