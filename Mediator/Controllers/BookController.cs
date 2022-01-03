using Microsoft.AspNetCore.Mvc;
using Mediator.Model;
using Mediator.Data;
using System.Collections.Generic;
using AutoMapper;
using Mediator.Dtos;
using MediatR;
using Mediator.Queries;
using System.Threading.Tasks;
using Mediator.Commands;
using System;

namespace Mediator.Controllers
{ 
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BookController( IMediator mediator){
                
              _mediator = mediator;
        }

      [HttpGet]
       public async Task<ActionResult>  getallBooks(){
          
             var query = new GetAllBooksQuery();
             var result = await _mediator.Send(query);
             return Ok(result);
       }

       [HttpGet("{id}")]
       public async Task<ActionResult> getBooksById(int id){
         
          var query = new GetBooksByIdQuery(id);
          var result = await _mediator.Send(query);
          return result != null ? Ok(result) : NotFound();
       }

       [HttpPost]
       public async Task<ActionResult> CreateBook([FromBody] CreateBookCommands commnds){

            var result = await _mediator.Send(commnds);
            return Ok(result);
       }   
    }
}