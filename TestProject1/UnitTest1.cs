using static System.Reflection.Metadata.BlobBuilder;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AddBook()
        {
            bool isAdded;
            List<Book> books = new List<Book>();
            Book book = new Book()
            {
                Author = "nj",
                Title = "Test",
                ISBN = "jfrf"
            };
             
            books.Add(book);
            
            if (books.Contains(book))
                isAdded = true;
            else 
                isAdded = false;

            Assert.IsTrue(isAdded);
        }

        [Test]
        public void DeleteBook()
        {
            bool isRemove;
            List<Book> books = new List<Book>();
            Book book = new Book()
            {
                Author = "nj",
                Title = "Test",
                ISBN = "jfrf"
            };
            books.Add(book);

            var find = books.FirstOrDefault(s => s.ISBN == book.ISBN);
            if (find != null)
                books.Remove(find);

            if (!books.Contains(book))
                isRemove = true;
            else
                isRemove = false;

            Assert.IsTrue(isRemove);
        }

        [Test]
        public void FindBookByTitle()
        {
            bool isFind;

            List<Book> books = new List<Book>();
            Book book = new Book()
            {
                Author = "nj",
                Title = "Test",
                ISBN = "jfrf"
            };
            books.Add(book);

            var find = books.FirstOrDefault(s => s.Title == book.Title);
            if (find != null)
                isFind = true;
            else 
                isFind = false;
            Assert.IsTrue(isFind);


            Type type = book.GetType();
            var propName = type.GetProperty("Title");
            Assert.IsNotNull(propName);
            Assert.That(propName.PropertyType, Is.EqualTo(typeof(string)));
        }
      
    }
}