using BookStore.IModels;
using System;
using System.Collections.Generic;

namespace BookStore.DAL
{
    public class Book :IBook
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<IAuthor> Authors { get; set; }
        public ICategory Category { get; set; }
        public string Description { get; set; }
        public DateTime CreationData { get; set; }
        public string ImageUrl { get; set; }
    }
}