﻿using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookDal bookDal = new EfBookDal();
            BookManager bookManager = new BookManager(bookDal);

            //var b1 = new Book { AuthorId = 11, CategoryId = 102, Title = "Handan", Description = "İstanbul'da geçen bir aşk hikayesi." };
            
            //bookManager.Add(b1);

            foreach (var book in bookManager.GetBookDetails().Data)
            {
                Console.WriteLine("Başlık : " + book.Title);
                Console.WriteLine("Yazar : " + book.FirstName + " " + book.LastName);
                Console.WriteLine("Tür : " + book.CategoryName);
                Console.WriteLine("Açıklama : " + book.Description);
                Console.WriteLine("---------------------------------");

            }
            Console.WriteLine();
            var r1 = bookManager.GetBooks();
            foreach (var b in r1.Data)
            {
                Console.WriteLine(b.Title + " : " + b.Description);
                Console.WriteLine("---------------------------------");
            }
            Console.WriteLine(r1.Message);
        }
    }
}
