using System.Collections.Generic;

namespace BookStore.IModels
{
    public interface IAuthor
    {
        int ID { get; set; }
        string Name { get; set; }
        ICollection<IBook> Books { get; set; }
    }
}