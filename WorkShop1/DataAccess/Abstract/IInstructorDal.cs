using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop1.Entities.Concrete;

namespace WorkShop1.DataAccess.Abstract
{
    public  interface IInstructorDal
    {

        void Add(Instructor instructor);
        void Delete(int id);
        void Update(Instructor instructor);
        List<Instructor> GetAll();
        Instructor GetById(int id);
        void PrintAll(List<Instructor> instructors);
        void PrintInstructor(Instructor instructor);
    }
}
