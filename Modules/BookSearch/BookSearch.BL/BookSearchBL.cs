using BookStore.DAL;
using System.Linq;

namespace BookSearch.BL
{
    public class BookSearchBL:IBookSearchBL
    {
        public BookSearchBL(BooksDBContext booksDBContext)
        {
            //int count = booksDBContext.Books.Count();
            //booksDBContext.SaveChanges();

        }
    }


    public class BookSearchBL2 : IBookSearchBL2
    {
        public BookSearchBL2(BooksDBContext booksDBContext)
        {
            ////booksDBContext.Books.Add(new Book() { CreationData = System.DateTime.Now});
            ////booksDBContext.Books.Add(new Book() { CreationData = System.DateTime.Now });
            ////booksDBContext.Books.Add(new Book() { CreationData = System.DateTime.Now });
            ////booksDBContext.Books.Add(new Book() { CreationData = System.DateTime.Now });
            ////booksDBContext.Books.Add(new Book() { CreationData = System.DateTime.Now });

            ////int count2 = booksDBContext.Books.Count();
        }
    }

    public interface IBookSearchBL2
    {
    }
}