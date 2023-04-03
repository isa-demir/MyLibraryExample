using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public IResult Add(Book book)
        {
            _bookDal.Add(book);
            return new SuccessResult(book.Title + " added successfully.");
        }

        public IDataResult<Book> GetBookById(int id)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(p => p.BookId == id));
        }

        public IDataResult<List<BookDetailDto>> GetBookDetails()
        {
            return new SuccessDataResult<List<BookDetailDto>>(_bookDal.GetBookDetails());
        }

        public IDataResult<List<Book>> GetBooks()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(), "Kitaplar başarıyla getirildi.");
        }
    }
}
