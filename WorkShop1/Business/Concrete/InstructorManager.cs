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
    public class InstructorManager : IInstrocturService
    {
        IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {   //Business Rules    
            _instructorDal = instructorDal;
        }

        public void Add(Instructor instructor)
        {   //Business Rules
            _instructorDal.Add(instructor);
        }

        public void Delete(int id)
        {   //Business Rules
            _instructorDal.Delete(id);
        }

        public List<Instructor> GetAll()
        {   //Business Rules
            return _instructorDal.GetAll();
        }

        public Instructor GetById(int id)
        {   //Business Rules
            return _instructorDal.GetById(id);
        }

        public void PrintAll(List<Instructor> instructors)
        {
            _instructorDal.PrintAll(instructors);
        }

        public void PrintCourse(Instructor instructor)
        {
            _instructorDal.PrintInstructor(instructor);
        }

        public void Update(Instructor instructor)
        {   //Business Rules
            _instructorDal.Update(instructor);
        }
    
        }

 }


