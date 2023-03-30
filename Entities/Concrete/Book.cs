using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Book : IEntity
    {
        public int BookId { get; set; }
        public short AuthorId { get; set; }
        public short CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
