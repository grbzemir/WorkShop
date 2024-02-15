using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop1.Entities.Concrete;

namespace WorkShop1.DataAccess.Abstract
{
    public interface ICategoryDal
    {

        void Add(Category category);
        void Delete(int id);
        void Update(Category category);
        public List<Category> GetAll();
        Category GetById(int id);
        public void PrintAll(List<Category> categories);
        void PrintCategory(Category category);
    }
}
