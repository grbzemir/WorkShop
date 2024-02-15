using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop1.Business.Abstract;
using WorkShop1.DataAccess.Abstract;
using WorkShop1.Entities.Concrete;

namespace WorkShop1.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {   //Constructor
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {   //Business Rules
            _courseDal.Add(course);
        }

        public void Delete(int id)
        {   //Business Rules
            _courseDal.Delete(id);
        }

        public List<Course> GetAll()
        {   //Business Rules
            return _courseDal.GetAll();
        }

        public Course GetById(int id)
        {   //Business Rules
            return _courseDal.GetById(id);
        }

        public void PrintAll(List<Course> courses)
        {
            _courseDal.PrintAll(courses);
        }

        public void PrintCourse(Course course)
        {
            _courseDal.PrintCourse(course);
        }

        public void Update(Course course)
        {   //Business Rules
            _courseDal.Update(course);
        }
    }

    }
