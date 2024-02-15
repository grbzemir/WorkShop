using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop1.Entities.Concrete;

namespace WorkShop1.Business.Abstract
{
    internal interface IInstrocturService
    {
        void Add(Instructor instructor);
        void Delete(int id);
        void Update(Instructor instructor);
        List<Instructor> GetAll();
        Instructor GetById(int id);
        void PrintAll(List<Instructor> instructors);
        void PrintCourse(Instructor instructor);
    }
}
