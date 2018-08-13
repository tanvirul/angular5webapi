using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDataStore.BooksDataStore
{
    public class BookDataStore : IBookDataStore
    {
        
        public BookDataStore()
        {
            
        }
        public IEnumerable<string> GetAllBooks()
        {
            List<string> names = new List<string>();

            using (BookDataContext context = new BookDataContext())
            {
                var depts = context.Department.Select(x => x).ToList();
                foreach(var dept in depts)
                {
                    names.Add(dept.Name);
                }
            }
            return names;
        }
    }
}