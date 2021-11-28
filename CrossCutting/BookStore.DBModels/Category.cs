using BookStore.IModels;
using System.Collections.Generic;

namespace BookStore.DAL
{
    public class Category:ICategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Name3 { get; set; }
        public ICollection<IBook> Books { get; set; }
       
    }
}