using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop1.Entities.Concrete;

namespace WorkShop1.DataAccess.Abstract
{
    public interface ICourseDal
    {

        void Add(Course Course);

        void Update(Course Course);

        void Delete(Course Course);

        List<Course> GetAll();

        Course GetById(int id);

        public void PrintAll(List<Course> courses);

        void PrintCourse(Course course);
        void Delete(int id);
    }
}
