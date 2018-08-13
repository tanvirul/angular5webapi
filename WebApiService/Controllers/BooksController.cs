using AppService.BookService;
using AppService.BookService.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiService.Controllers
{

    public class BooksController : ApiController
    {
        private IBookService _booksService;

        public BooksController()
        {
            _booksService = new BookService();
        }


        [HttpGet]
        [Route("api/books/GetAllBooks")]
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return _booksService.GetAllBooks();
            //string aa = ConfigurationManager.ConnectionStrings["BookData"].ConnectionString;
            //return new string[] {  };
            //return aa;

        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}