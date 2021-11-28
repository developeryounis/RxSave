using System;
using System.Collections.Generic;

namespace BookStore.IModels
{
    public interface IBook
    {
        int ID { get; set; }
        string Name { get; set; }
        ICollection<IAuthor> Authors { get; set; }
        ICategory Category { get; set; }
        string Description { get; set; }
        DateTime CreationData { get; set; }
        string ImageUrl { get; set; }
    }
}