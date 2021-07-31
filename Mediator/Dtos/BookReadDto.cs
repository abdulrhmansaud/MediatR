using System;
using AutoMapper.Configuration.Annotations;

namespace Mediator.Dtos
{
    public class BookReadDto
    {
        public int id { get; set;}

        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public bool availability { get; set; }
    }
}