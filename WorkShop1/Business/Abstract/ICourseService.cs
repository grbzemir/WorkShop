using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop1.Entities.Concrete;

namespace WorkShop1.Business.Abstract
{
    public interface ICourseService
    {
        void Add(Course course);
        void Delete(int id);
        void Update(Course course);
        List<Course> GetAll();
        Course GetById(int id);
        void PrintAll(List<Course> courses);
        void PrintCourse(Course course);
    }
}
