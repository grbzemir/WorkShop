using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop1.DataAccess.Abstract;
using WorkShop1.Entities.Concrete;

namespace WorkShop1.DataAccess.Concrete
{
    public class CategoryDal:ICategoryDal
    {
        public List<Category> _categories;

        public CategoryDal()
        {
            _categories = new List<Category>
            {
                new Category { CategoryName="C#,",CategoryId=1,CategoryDescription="0 dan ileri seviyeye C# eğitimleri."},
                new Category { CategoryName="JAVA,",CategoryId=2,CategoryDescription="0 dan ileri seviyeye Java eğitimleri."},
                new Category { CategoryName="PYTHON,",CategoryId=3,CategoryDescription="0 dan ileri seviyeye Python eğitimleri."}
            };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(int id)
        {
            foreach (Category category in _categories) 
            
            { 
                 
                if (category.CategoryId == id)
                {
                    _categories.Remove(category);
                    break;
                }
            }
        }

        public void Update(Category category)
        {
            var categoryToUpdate = _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            categoryToUpdate.CategoryName = category.CategoryName;
            categoryToUpdate.CategoryDescription = category.CategoryDescription;
            
        }

        public List<Category> GetAll()
        {
           return _categories.ToList();
        }

        public Category GetById(int id)
        {
            
            return _categories.SingleOrDefault(c => c.CategoryId == id);

        }

        public void PrintAll(List<Category> categories)
        {
            foreach (var category in categories)
            {
                Console.WriteLine("Kategori Adı: " + category.CategoryName);
                Console.WriteLine("Kategori Açıklaması: " + category.CategoryDescription);
            }
        }

        public void PrintCategory(Category category)
        {
            Console.WriteLine("Kategori ID'si: " + category.CategoryId);
            Console.WriteLine("Kategori İsmi: " + category.CategoryName);
            Console.WriteLine("Kategori Açıklaması: " + category.CategoryDescription);
            Console.WriteLine("");
        }
    }
}
