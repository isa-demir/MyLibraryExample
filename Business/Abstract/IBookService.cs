using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookService
    {
        IResult Add(Book book);
        IDataResult<List<Book>> GetBooks();
        IDataResult<Book> GetBookById(int id);
        IDataResult<List<BookDetailDto>> GetBookDetails();
    }
}
