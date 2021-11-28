using System.Collections.Generic;

namespace BookStore.IModels
{
    public interface ICategory
    {
        int Id { get; set; }
        string Name { get; set; }
        ICollection<IBook> Books { get; set; }
    }
}