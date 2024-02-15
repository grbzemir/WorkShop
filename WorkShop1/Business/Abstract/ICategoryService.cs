using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop1.Entities.Concrete;

namespace WorkShop1.Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Delete(int id);
        void Update(Category category);
        List<Category> GetAll();
        Category GetById(int id);
        void PrintAll(List<Category> categories);
        void PrintCourse(Category category);
    }

}


