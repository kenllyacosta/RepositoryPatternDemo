using Entities.POCOs;
using System.Collections.Generic;

namespace Entities.Interfaces
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        IEnumerable<Category> GetAll();
    }
}