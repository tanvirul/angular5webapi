using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataStore.BooksDataStore
{
    public interface IBookDataStore
    {
        IEnumerable<string> GetAllBooks();
    }
}
