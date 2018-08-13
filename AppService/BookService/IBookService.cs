using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.BookService.Interfaces
{
    public interface IBookService
    {
        IEnumerable<string> GetAllBooks();
    }
}
