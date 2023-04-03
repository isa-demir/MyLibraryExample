using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, LibraryContext>, IBookDal
    {
        public List<BookDetailDto> GetBookDetails()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var result = from b in context.Books
                             join a in context.Authors on b.AuthorId equals a.AuthorId
                             join c in context.Categories on b.CategoryId equals c.CategoryId
                             select new BookDetailDto { Title = b.Title, FirstName = a.FirstName, LastName = a.LastName, CategoryName = c.CategoryName, Description = b.Description};
                return result.ToList();
            }
        }

        
    }
}
