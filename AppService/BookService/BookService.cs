using AppDataStore.BooksDataStore;
using AppService.BookService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppService.BookService
{
    public class BookService : IBookService
    {
        private IBookDataStore _bookDataStore;

        public BookService(){

            _bookDataStore = new BookDataStore();
        }

        public IEnumerable<string> GetAllBooks()
        {
            return _bookDataStore.GetAllBooks();
        }
    }
}