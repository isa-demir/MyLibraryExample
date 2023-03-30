using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookService
    {
        void Add(Book book);
        List<Book> GetBooks();
        Book GetBookById(int id);
        List<BookDetailDto> GetBookDetails();
    }
}
