using BookStore.IModels;
using System.Collections.Generic;

namespace BookStore.DAL
{
    public class Author:IAuthor
    {
      
        public Author()
        {
           
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<IBook> Books {get; set; }
        //ICollection<IBook> IAuthor.Books { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}