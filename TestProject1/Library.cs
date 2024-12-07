using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Library
    {
        
        public List<Book> Books { get; set; }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(string isbn)
        { 
            var find = Books.FirstOrDefault(s => s.ISBN == isbn);
            if (find != null) 
            Books.Remove(find);
        }

        public Book FindBookByTitle(string title) 
        { 
            var find = Books.FirstOrDefault(s => s.Title == title);
            if (find == null)
                return null;
            else
            {
                Book book = new Book()
                {
                    Title = find.Title,
                    Author = find.Author,
                    ISBN = find.ISBN
                };
                return book;
            }
            
        }

        public List<Book> ListAllBooks()
        {
            return new List<Book>();
        }
    }


}
